using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ParameterTable
{
    public class Param
    {
        private static Param _Parameter = null;

        public static Param Parameter
        {
            get
            {
                if (_Parameter == null)
                    _Parameter = new Param();
                return _Parameter;
            }
        }

        public double? paramZOLLERmeasuringheight { get; set; } = null;
        public double? paramEndBladeandBackCorner { get; set; } = null;
        public double? paramEndBladeTwoBackCorners { get; set; } = null;
        public double? paramTriplebackAngleGASH { get; set; } = null;
        public double? paramTooldiameter { get; set; } = null;
        public double? paramPCDGrooveLength { get; set; } = null;
        public double? paramHelixAngle { get; set; } = null;
        public double? paramBladeNumber { get; set; } = null;
        public double? paramLaserConeAngle { get; set; } = null;
        public double? paramOverallRotationAngleOfAxisA { get; set; } = null;
        public double? paramTheMachiningEndFaceIsRoTatedRelativeToTheSpiralGrooveAAxis { get; set; } = null;
        public double? paramProcessingEndFaceZAxisMovementSpeed { get; set; } = null;
        public double? paramEndFaceOnePostXAxisOffset { get; set; } = null;
        public double? paramEndFaceTwoAfterXaxisOffset { get; set; } = null;
        public double? paramEndFaceThreeRearXAxisOffsetGASH {  get; set; } = null;
        public double? paramEndFaceThreeRearYAxisOffsetGASH { get; set; } = null;
        public double? paramProcessingTimeForTheFinalPositionOfTheThirdEndFace { get; set; } = null;
        public double? paramDistanceFromTheStartingPointOfAxialOffsetDuringSlotting { get; set; } = null;
        public double? paramSlottingSpeedFValue { get; set; } = null;
        public double? paramCoreDiameterCompensationValue { get; set; } = null;
        public double? paramProcessingBackClearanceRelativeToSpiralGrooveAAxisRotation { get; set; } = null;
        public double? paramProcessingBackgapSpeedFValue { get; set; } = null;
        public double? paramBackgapProcessingTimes { get; set; } = null;
        public double? paramNumberOfPlaneBackspaces { get; set; } = null;
        public double? paramDepthOfPlaneBackClearance { get; set; } = null;
        public double? paramPlaneBackspaceSpacingAngle { get; set; } = null;
        public double? paramPostProcessingAllowance { get; set; } = null;
        public double? paramProcessingSequence {  get; set; } = null;
        public double? paramPostProcessingDirection { get; set; } = null;








        public static void SaveDataAsJson()
        {
            // 序列化全局变量为JSON字符串
            string json = JsonConvert.SerializeObject(Parameter, Formatting.Indented);
            //显示保存文件对话框并写入JSON字符串到用户选择的文件
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON file (*.json)|*.json";
            saveFileDialog.Title = "Save parameters as JSON";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, json);
                MessageBox.Show("数据导出成功!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool AllPropertiesIsNullEmpty()
        {
            Param param = new Param();
            foreach(PropertyInfo property in param.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(double?))
                {
                    double? value = (double?)property.GetValue(this);
                    if (value == null)
                    {
                        return false;
                    }
                }
               
            }
            return true;
        }
     
    }
}
