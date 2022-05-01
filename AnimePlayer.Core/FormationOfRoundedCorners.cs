using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimePlayer.Class;
using AnimePlayer.CNM;

namespace AnimePlayer.Core
{
    public static class FormationOfRoundedCorners
    {
        public static void SetSettingsToControls(List<SimplifiedElementSetting> simplifiedElementSettings)
        {
            try
            {
                foreach(SimplifiedElementSetting simplifiedElementSetting in simplifiedElementSettings)
                {
                    if (simplifiedElementSetting == null)
                        break;
                    if (simplifiedElementSetting.Name == null)
                        break;
                    if (simplifiedElementSetting.Value == null)
                        break;
                    foreach (var item in ApplicationFormsHelper.FindControlInAllForms(simplifiedElementSetting.Name))
                    {
                        try
                        {
                            ControlsNewMethods.RoundingControl rc = new ControlsNewMethods.RoundingControl();
                            rc.TargetControl = item;
                            rc.CornerRadius = int.Parse(simplifiedElementSetting.Value.ToString());
                        }
                        catch (Exception exParse)
                        {
                            Console.Error.WriteLine(exParse.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
