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
    public partial class ParamPage2 : UserControl
    {
        public ParamPage2()
        {
            InitializeComponent();
        }

        private Dictionary<string, Image> imageDict;

        private void ParamPage2_Load(object sender, EventArgs e)
        {
            imageDict = new Dictionary<string, Image>();
            imageDict.Add("textBoxNumberOfPlaneBackspaces", Properties.Resources.NumberOfPlaneBackspaces);
            imageDict.Add("textBoxDepthOfPlaneBackClearance", Properties.Resources.DepthOfPlaneBackClearance);
            imageDict.Add("textBoxPlaneBackspaceSpacingAngle", Properties.Resources.PlaneBackspaceSpacingAngle);



            comboBoxProcessingSequence.Items.Add("1,端面-槽/背隙");
            comboBoxProcessingSequence.Items.Add("2,槽/背隙-端面");
            comboBoxProcessingSequence.Items.Add("3,端面");
            comboBoxProcessingSequence.Items.Add("4,槽");
            comboBoxProcessingSequence.Items.Add("5,背隙");

            comboBoxPostProcessingDirection.Items.Add("1,前->后");
            comboBoxPostProcessingDirection.Items.Add("2,后->前");
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
        



        private void textBoxEndFaceThreeRearXAxisOffsetGASH_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxEndFaceThreeRearXAxisOffsetGASH.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramEndFaceThreeRearXAxisOffsetGASH = value.Value;
            }
            else
            {
                Param.Parameter.paramEndFaceThreeRearXAxisOffsetGASH = null;
            }
        }

        private void textBoxEndFaceThreeRearYAxisOffsetGASH_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxEndFaceThreeRearYAxisOffsetGASH.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramEndFaceThreeRearYAxisOffsetGASH = value.Value;
            }
            else
            {
                Param.Parameter.paramEndFaceThreeRearYAxisOffsetGASH = null;
            }
        }

        private void textBoxProcessingTimeForTheFinalPositionOfTheThirdEndFace_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxProcessingTimeForTheFinalPositionOfTheThirdEndFace.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramProcessingTimeForTheFinalPositionOfTheThirdEndFace = value.Value;
            }
            else
            {
                Param.Parameter.paramProcessingTimeForTheFinalPositionOfTheThirdEndFace = null;
            }
        }

        private void textBoxDistanceFromTheStartingPointOfAxialOffsetDuringSlotting_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxDistanceFromTheStartingPointOfAxialOffsetDuringSlotting.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramDistanceFromTheStartingPointOfAxialOffsetDuringSlotting = value.Value;
            }
            else
            {
                Param.Parameter.paramDistanceFromTheStartingPointOfAxialOffsetDuringSlotting = null;
            }
        }

        private void textBoxSlottingSpeedFValue_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxSlottingSpeedFValue.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramSlottingSpeedFValue = value.Value;
            }
            else
            {
                Param.Parameter.paramSlottingSpeedFValue = null;
            }
        }

        private void textBoxCoreDiameterCompensationValue_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxCoreDiameterCompensationValue.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramCoreDiameterCompensationValue = value.Value;
            }
            else
            {
                Param.Parameter.paramCoreDiameterCompensationValue = null;
            }
        }

        private void textBoxProcessingBackClearanceRelativeToSpiralGrooveAAxisRotation_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxProcessingBackClearanceRelativeToSpiralGrooveAAxisRotation.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramProcessingBackClearanceRelativeToSpiralGrooveAAxisRotation = value.Value;
            }
            else
            {
                Param.Parameter.paramProcessingBackClearanceRelativeToSpiralGrooveAAxisRotation = null;
            }
        }

        private void textBoxProcessingBackgapSpeedFValue_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxProcessingBackgapSpeedFValue.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramProcessingBackgapSpeedFValue = value.Value;
            }
            else
            {
                Param.Parameter.paramProcessingBackgapSpeedFValue = null;
            }
        }

        private void textBoxBackgapProcessingTimes_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxBackgapProcessingTimes.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramBackgapProcessingTimes = value.Value;
            }
            else
            {
                Param.Parameter.paramBackgapProcessingTimes = null;
            }
        }

        private void textBoxNumberOfPlaneBackspaces_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxNumberOfPlaneBackspaces.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramNumberOfPlaneBackspaces = value.Value;
            }
            else
            {
                Param.Parameter.paramNumberOfPlaneBackspaces = null;
            }
        }

        private void textBoxDepthOfPlaneBackClearance_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxDepthOfPlaneBackClearance.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramDepthOfPlaneBackClearance = value.Value;
            }
            else
            {
                Param.Parameter.paramDepthOfPlaneBackClearance = null;
            }
        }

        private void textBoxPlaneBackspaceSpacingAngle_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxPlaneBackspaceSpacingAngle.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramPlaneBackspaceSpacingAngle = value.Value;
            }
            else
            {
                Param.Parameter.paramPlaneBackspaceSpacingAngle = null;
            }
        }

        private void textBoxPostProcessingAllowance_TextChanged(object sender, EventArgs e)
        {
            double? value = ParseTextToDouble(textBoxPostProcessingAllowance.Text);
            if (value.HasValue)
            {
                Param.Parameter.paramPostProcessingAllowance = value.Value;
            }
            else
            {
                Param.Parameter.paramPostProcessingAllowance = null;
            }
        }
        private void comboBoxProcessingSequence_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedValue = comboBoxProcessingSequence.SelectedIndex + 1;
            Param.Parameter.paramProcessingSequence = selectedValue;

        }

        private void comboBoxPostProcessingDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = comboBoxPostProcessingDirection.SelectedIndex + 1;
            Param.Parameter.paramPostProcessingDirection = selectedValue;

        }
        private void comboBoxProcessingSequence_Click(object sender, EventArgs e)
        {
            pictureBoxParameter.Image = Properties.Resources.NoDiagram;
        }
        private void comboBoxPostProcessingDirection_Click(object sender, EventArgs e)
        {
            pictureBoxParameter.Image = Properties.Resources.NoDiagram;
        }

        
    }
}
