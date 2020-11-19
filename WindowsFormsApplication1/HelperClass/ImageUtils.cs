using System;
using System.Drawing;
using System.IO;
using WindowsFormsApplication1;

public class ImageUtils
{
    public static Image ConvertBinaryToImage(byte[] data)
    {
        try
        {
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
        }
        catch (Exception ex)
        {
            ProjectFunctions.SpeakError(ex.Message);
        }
        return null;
    }
}