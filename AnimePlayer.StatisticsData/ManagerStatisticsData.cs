using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimePlayer.StatisticsData
{
    public class ManagerStatisticsData
    {
        Process childProcess;
        public ManagerStatisticsData()
        {
            try
            {
                childProcess = new Process();
                childProcess.StartInfo.FileName = Application.ExecutablePath;
                childProcess.StartInfo.Arguments = "-OtherArgs -AnimePlayerStatisticsData";
                childProcess.Start();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Console.Error.WriteLine(ex.ToString());
            }
        }
        public void Exit()
        {
            if(childProcess != null)
                childProcess.Kill();
        }

    }
}
