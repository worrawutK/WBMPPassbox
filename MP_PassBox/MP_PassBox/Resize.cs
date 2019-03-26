// -------------------------------------------------------------------------------
//  Resizer
//  This class is used to dynamically resize and reposition all controls on a form.
//  Container controls are processed recursively so that all controls on the form
//  are handled.
// 
//  Usage:
//   Resizing functionality requires only three lines of code on a form:
// 
//   1. Create a form-level reference to the Resize class:
//      Dim myResizer as Resizer
// 
//   2. In the Form_Load event, call the  Resizer class FIndAllControls method:
//      myResizer.FindAllControls(Me)
// 
//   3. In the Form_Resize event, call the  Resizer class ResizeAllControls method:
//      myResizer.ResizeAllControls(Me)
// 
// -------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class Resize
{

    // ----------------------------------------------------------
    //  ControlInfo
    //  Structure of original state of all processed controls
    // ----------------------------------------------------------
    private struct ControlInfo
    {

        public string name;

        public string parentName;

        public double leftOffsetPercent;

        public double topOffsetPercent;

        public double heightPercent;

        public int originalHeight;

        public int originalWidth;

        public float widthPercent;

        public float originalFontSize;

        public int originalcolumnWidth;

        public int originalcolumnHight;
    }

    // -------------------------------------------------------------------------
    //  ctrlDict
    //  Dictionary of (control name, control info) for all processed controls
    // -------------------------------------------------------------------------
    private Dictionary<string, ControlInfo> ctrlDict = new Dictionary<string, ControlInfo>();

    public void FindAllControls(Control thisCtrl)
    {
        // -- If the current control has a parent, store all original relative position
        // -- and size information in the dictionary.
        // -- Recursively call FindAllControls for each control contained in the
        // -- current Control
        foreach (Control ctl in thisCtrl.Controls)
        {
            try
            {

                if ((ctl.GetType() == typeof(DataGridView)))
                {
                    DataGridView Grid = ((DataGridView)(ctl));
                    if (!(ctl.Parent == null))
                    {
                        object parentHeight = ctl.Parent.Height;
                        object parentWidth = ctl.Parent.Width;
                        ControlInfo c = new ControlInfo();
                        c.name = Grid.Name;
                        c.parentName = Grid.Parent.Name;
                        c.topOffsetPercent = (Convert.ToDouble(Grid.Top) / Convert.ToDouble(parentHeight));
                        c.leftOffsetPercent = (Convert.ToDouble(Grid.Left) / Convert.ToDouble(parentWidth));
                        c.heightPercent = (Convert.ToDouble(Grid.Height) / Convert.ToDouble(parentHeight));
                        c.widthPercent = (float)(Convert.ToDouble(Grid.Width) / Convert.ToDouble(parentWidth));
                        c.originalFontSize = Grid.DefaultCellStyle.Font.Size;
                        // Grid.Font.Size
                        c.originalHeight = Grid.Height;
                        c.originalWidth = Grid.Width;
                        //    c.originalcolumnWidth = Grid.Columns(0).Width
                        //  c.originalcolumnHight = Grid.Rows(0).Height
                        ctrlDict.Add(c.name, c);
                    }

                }
                else if (!(ctl.Parent == null))
                {
                    object parentHeight = ctl.Parent.Height;
                    object parentWidth = ctl.Parent.Width;
                    ControlInfo c = new ControlInfo();
                    c.name = ctl.Name;
                    c.parentName = ctl.Parent.Name;
                    c.topOffsetPercent = (Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight));
                    c.leftOffsetPercent = (Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth));
                    c.heightPercent = (Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight));
                    c.widthPercent = (float)(Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth));
                    c.originalFontSize = ctl.Font.Size;
                    c.originalHeight = ctl.Height;
                    c.originalWidth = ctl.Width;
                    ctrlDict.Add(c.name, c);
                }

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            if ((ctl.Controls.Count > 0))
            {
                this.FindAllControls(ctl);
            }

        }

        // -- For Each
    }

    // ----------------------------------------------------------------------------------------
    //  ResizeAllControls
    //  Recursive function to resize and reposition all controls contained in the Control
    //  dictionary
    // ----------------------------------------------------------------------------------------
    public void ResizeAllControls(Control thisCtrl)
    {
        float fontRatioW;
        float fontRatioH;
        float fontRatio;
        Font f;
        // -- Resize and reposition all controls in the passed control
        foreach (Control ctl in thisCtrl.Controls)
        {

            try
            {
                if (ctl.GetType() == typeof(PictureBox))
                {

                    if (!(ctl.Parent == null))
                    {
                        int parentHeight = ctl.Parent.Height;
                        int parentWidth = ctl.Parent.Width;
                        ControlInfo c = new ControlInfo();
                        bool ret = false;
                        try
                        {
                            // -- Get the current control's info from the control info dictionary
                            ret = ctrlDict.TryGetValue(ctl.Name, out c);
                            // -- If found, adjust the current control based on control relative
                            // -- size and position information stored in the dictionary
                            if (ret)
                            {
                                // -- Size
                                ctl.Width = Convert.ToInt32(parentWidth * c.widthPercent);//Convert.ToInt32(parentWidth * c.widthPercent);
                                ctl.Height = Convert.ToInt32(parentWidth * c.widthPercent / 1.47);//Convert.ToInt32(parentHeight * c.heightPercent);
                                // -- Position
                                ctl.Top = Convert.ToInt32(parentHeight * c.topOffsetPercent);
                                ctl.Left = Convert.ToInt32(parentWidth * c.leftOffsetPercent);
                                // -- Font
                                f = ctl.Font;
                                fontRatioW = ((float)ctl.Width / (float)c.originalWidth);
                                fontRatioH = ((float)ctl.Height / (float)c.originalHeight);
                                fontRatio = (((float)fontRatioW + (float)fontRatioH) / (float)2);
                                // -- average change in control Height and Width
                                ctl.Font = new Font(f.FontFamily, (c.originalFontSize * fontRatio), f.Style);
                                //f = ctl.Font;
                            }

                        }
                        catch (System.Exception)
                        {



                        }

                    }
                    goto NotResize;
                }
                if (ctl.GetType().Name == "CircularButton")
                {
                    if (!(ctl.Parent == null))
                    {
                        int parentHeight = ctl.Parent.Height;
                        int parentWidth = ctl.Parent.Width;
                        ControlInfo c = new ControlInfo();
                        bool ret = false;
                        try
                        {
                            // -- Get the current control's info from the control info dictionary
                            ret = ctrlDict.TryGetValue(ctl.Name, out c);
                            // -- If found, adjust the current control based on control relative
                            // -- size and position information stored in the dictionary
                            if (ret)
                            {
                                // -- Size
                                ctl.Width = Convert.ToInt32(parentHeight * c.heightPercent);//Convert.ToInt32(parentWidth * c.widthPercent);
                                ctl.Height = Convert.ToInt32(parentHeight * c.heightPercent);//Convert.ToInt32(parentHeight * c.heightPercent);
                                // -- Position
                                ctl.Top = Convert.ToInt32(parentHeight * c.topOffsetPercent);
                                ctl.Left = Convert.ToInt32(parentWidth * c.leftOffsetPercent);
                                // -- Font
                                f = ctl.Font;
                                fontRatioW = ((float)ctl.Width / (float)c.originalWidth);
                                fontRatioH = ((float)ctl.Height / (float)c.originalHeight);
                                fontRatio = (((float)fontRatioW + (float)fontRatioH) / (float)2);
                                // -- average change in control Height and Width
                                ctl.Font = new Font(f.FontFamily, (c.originalFontSize * fontRatio), f.Style);
                                //f = ctl.Font;
                            }

                        }
                        catch (System.Exception)
                        {



                        }

                    }
                    goto NotResize;
                }

                if (!(ctl.Parent == null))
                {
                    int parentHeight = ctl.Parent.Height;
                    int parentWidth = ctl.Parent.Width;
                    ControlInfo c = new ControlInfo();
                    bool ret = false;
                    try
                    {
                        // -- Get the current control's info from the control info dictionary
                        ret = ctrlDict.TryGetValue(ctl.Name, out c);
                        // -- If found, adjust the current control based on control relative
                        // -- size and position information stored in the dictionary
                        if (ret)
                        {
                            // -- Size
                            ctl.Width = Convert.ToInt32(parentWidth * c.widthPercent);
                            ctl.Height = Convert.ToInt32(parentHeight * c.heightPercent);
                            // -- Position
                            ctl.Top = Convert.ToInt32(parentHeight * c.topOffsetPercent);
                            ctl.Left = Convert.ToInt32(parentWidth * c.leftOffsetPercent);
                            // -- Font
                            f = ctl.Font;
                            fontRatioW = ((float)ctl.Width / (float)c.originalWidth);
                            fontRatioH = ((float)ctl.Height / (float)c.originalHeight);
                            fontRatio = (((float)fontRatioW + (float)fontRatioH) / (float)2);
                            // -- average change in control Height and Width
                            ctl.Font = new Font(f.FontFamily, (c.originalFontSize * fontRatio), f.Style);
                            //f = ctl.Font;
                        }

                    }
                    catch (System.Exception)
                    {



                    }

                }

            }
            catch (Exception)
            {

            }
            NotResize:
            // -- Recursive call for controls contained in the current control
            if ((ctl.Controls.Count > 0))
            {
                this.ResizeAllControls(ctl);
            }

            // -- For Each
        }

    }
}