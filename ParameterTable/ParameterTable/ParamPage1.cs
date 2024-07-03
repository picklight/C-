using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterTable
{
    public partial class ParamPage1 : UserControl
    {
      
        public ParamPage1()
        {
            InitializeComponent();
        }
        private Dictionary<string, Image> imageDict;

        private void ParamPage1_Load(object sender, EventArgs e)
        {
            imageDict = new Dictionary<string, Image>();
            imageDict.Add("textBoxZOLLERmeasuringheight", Properties.Resources.ZOLLERmeasuringheight);
            imageDict.Add("textBoxEndBladeandBackCorner", Properties.Resources.EndBladeandBackCorner);
            imageDict.Add("textBoxEndBladeTwoBackCorners", Properties.Resources.EndBladeTwoBackCorners);
            imageDict.Add("textBoxTriplebackAngleGASH", Properties.Resources.TriplebackAngleGASH);
            imageDict.Add("textBoxTooldiameter", Properties.Resources.Tooldiameter);
            imageDict.Add("textBoxPCDGrooveLength", Properties.Resources.PCDGrooveLength);
            imageDict.Add("textBoxHelixAngle", Properties.Resources.HelixAngle);
            imageDict.Add("textBoxBladeNumber", Properties.Resources.BladeNumber); 
            imageDict.Add("textBoxEndFaceOnePostXAxisOffset", Properties.Resources.EndFaceOnePostXAxisOffset);
            imageDict.Add("textBoxEndFaceTwoAfterXaxisOffset", Properties.Resources.EndFaceTwoAfterXaxisOffset);


        }

        private void textBox_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var name = textBox.Name;
            if (!imageDict.ContainsKey(name))
            {
                pictureBoxParameter.Image = Properties.Resources.NoDiagram;
                return;
            }
            pictureBoxParameter.Image = imageDict[name];
        }

        private double? ParseTextToDouble(string text)
        {
            if (string.IsNullOrWhiteSpace(text) || text == "-")
            {
                return null;
            }
            try
            {
                return Convert.ToDouble(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        

        private void textBoxZOLLERmeasuringheight_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxZOLLERmeasuringheight.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramZOLLERmeasuringheight = value.Value;
            }
            else
            {
                Param.Parameter.paramZOLLERmeasuringheight = null;
            }

        }

        private void textBoxEndBladeandBackCorner_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxEndBladeandBackCorner.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramEndBladeandBackCorner = value.Value;
            }
            else
            {
                Param.Parameter.paramEndBladeandBackCorner = null;
            }
        }

        private void textBoxEndBladeTwoBackCorners_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxEndBladeTwoBackCorners.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramEndBladeTwoBackCorners = value.Value;
            }
            else
            {
                Param.Parameter.paramEndBladeTwoBackCorners = null;
            }
        }

        private void textBoxTriplebackAngleGASH_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxTriplebackAngleGASH.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramTriplebackAngleGASH = value.Value;
            }
            else
            {
                Param.Parameter.paramTriplebackAngleGASH = null;
            }
        }

        private void textBoxTooldiameter_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxTooldiameter.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramTooldiameter = value.Value;
            }
            else
            {
                Param.Parameter.paramTooldiameter = null;
            }
        }

        private void textBoxPCDGrooveLength_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxPCDGrooveLength.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramPCDGrooveLength = value.Value;
            }
            else
            {
                Param.Parameter.paramPCDGrooveLength = null;
            }
        }

        private void textBoxHelixAngle_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxHelixAngle.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramHelixAngle = value.Value;
            }
            else
            {
                Param.Parameter.paramHelixAngle = null;
            }
        }

        private void textBoxBladeNumber_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxBladeNumber.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramBladeNumber = value.Value;
            }
            else
            {
                Param.Parameter.paramBladeNumber = null;
            }
        }

        private void textBoxLaserConeAngle_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxLaserConeAngle.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramLaserConeAngle = value.Value;
            }
            else
            {
                Param.Parameter.paramLaserConeAngle = null;
            }
        }

        private void textBoxOverallRotationAngleOfAxisA_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxOverallRotationAngleOfAxisA.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramOverallRotationAngleOfAxisA = value.Value;
            }
            else
            {
                Param.Parameter.paramOverallRotationAngleOfAxisA = null;
            }
        }

        private void textBoxTheMachiningEndFaceIsRoTatedRelativeToTheSpiralGrooveAAxis_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxTheMachiningEndFaceIsRoTatedRelativeToTheSpiralGrooveAAxis.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramTheMachiningEndFaceIsRoTatedRelativeToTheSpiralGrooveAAxis = value.Value;
            }
            else
            {
                Param.Parameter.paramTheMachiningEndFaceIsRoTatedRelativeToTheSpiralGrooveAAxis = null;
            }
        }

        private void textBoxProcessingEndFaceZAxisMovementSpeed_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxProcessingEndFaceZAxisMovementSpeed.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramProcessingEndFaceZAxisMovementSpeed = value.Value;
            }
            else
            {
                Param.Parameter.paramProcessingEndFaceZAxisMovementSpeed = null;
            }
        }

        private void textBoxEndFaceOnePostXAxisOffset_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxEndFaceOnePostXAxisOffset.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramEndFaceOnePostXAxisOffset = value.Value;
            }
            else
            {
                Param.Parameter.paramEndFaceOnePostXAxisOffset = null;
            }
        }

        private void textBoxEndFaceTwoAfterXaxisOffset_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxEndFaceTwoAfterXaxisOffset.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramEndFaceTwoAfterXaxisOffset = value.Value;
            }
            else
            {
                Param.Parameter.paramEndFaceTwoAfterXaxisOffset = null;
            }
        }
    }
}
