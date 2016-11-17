using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static private void WriteLineData(double opVal)
        {
            Console.WriteLine(String.Format("        <Line X1=\"200\" Y1=\"200\" X2=\"0\" Y2=\"200\" Stroke=\"Black\" StrokeThickness=\"1\" Opacity=\"{0}\" RenderTransformOrigin=\"0.5,0.5\" HorizontalAlignment=\"Center\" VerticalAlignment=\"Center\">", opVal));
        }

        static private void WriteLineRenderTransformData(double angleVal)
        {
            Console.WriteLine("            <Line.RenderTransform>");
            Console.WriteLine("                <TransformGroup>");
            Console.WriteLine("                    <ScaleTransform/>");
            Console.WriteLine("                    <SkewTransform/>");
            Console.WriteLine(String.Format("                    <RotateTransform Angle=\"{0}\"/>", angleVal));
            Console.WriteLine("                    <TranslateTransform/>");
            Console.WriteLine("                </TransformGroup>");
            Console.WriteLine("            </Line.RenderTransform>");
        }

        static private void WriteLineTriggersData()
        {
            Console.WriteLine("            <Line.Triggers>");
            Console.WriteLine("                <EventTrigger RoutedEvent=\"Line.Loaded\">");
            Console.WriteLine("                    <BeginStoryboard>");
            Console.WriteLine("                        <Storyboard>");
            Console.WriteLine("                            <DoubleAnimation Storyboard.TargetProperty=\"(Line.Opacity)\" To=\"0\" Duration=\"0:0:1\" AutoReverse=\"True\" RepeatBehavior=\"Forever\"/>");
            Console.WriteLine("                        </Storyboard>");
            Console.WriteLine("                    </BeginStoryboard>");
            Console.WriteLine("                </EventTrigger>");
            Console.WriteLine("            </Line.Triggers>");
        }

        static private void WriteLineClose()
        {
            Console.WriteLine("        </Line>");
        }

        static void Main(string[] args)
        {
            double opacityValue = 0.0;
            //double opacityStepValue1 = 0.00138;
            double opacityStepValue2 = 0.00069;

            for (double i = 0; i < 360.0; i += 0.25)
            {
                WriteLineData(opacityValue);
                opacityValue += opacityStepValue2;
                WriteLineRenderTransformData(i);
                //WriteLineTriggersData();
                WriteLineClose();
            }
        }
    }
}
