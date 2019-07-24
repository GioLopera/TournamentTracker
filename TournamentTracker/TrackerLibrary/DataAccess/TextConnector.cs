using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {
            /// Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            ///Find max Id
            int currentId = 1;
            
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            currentId += 1;

            ///Add new record with the new Id (max + 1)
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
