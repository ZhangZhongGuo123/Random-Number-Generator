using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Random_Number_Generator.Core.Contracts.Services;
using Random_Number_Generator.Core.Models;

namespace Random_Number_Generator.Core.Services
{
    public class NumberHistoryDataService : INumberHistoryDataService
    {
        private readonly string _csvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages\\cdcfecba-b1bc-4894-ba00-7b690d69e9fb_6kqrdgffy0twc\\LocalState\\history.csv");

        public async Task<IEnumerable<NumberHistory>> GetGridDataAsync()
        {
            List<NumberHistory> numberHistories = new List<NumberHistory>();

            await Task.Run(() =>
            {
                using (TextFieldParser parser = new TextFieldParser(_csvFilePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (fields.Length >= 4) // 确保每一行至少有4个字段
                        {
                            DateTime date;
                            int from, to, result;

                            if (DateTime.TryParse(fields[0], out date) && int.TryParse(fields[1], out from) && int.TryParse(fields[2], out to) && int.TryParse(fields[3], out result))
                            {
                                numberHistories.Add(new NumberHistory
                                {
                                    Date = date.ToString(),
                                    From = from,
                                    To = to,
                                    Result = result
                                });
                            }
                            else
                            {
                                // 处理解析错误，例如记录日志或抛出异常
                            }
                        }
                    }
                }
            });

            return numberHistories;
        }
    }
}