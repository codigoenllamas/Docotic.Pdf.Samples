﻿using System.Diagnostics;

namespace BitMiracle.Docotic.Pdf.Samples
{
    public static class SetPassword
    {
        public static void Main()
        {
            // NOTE: 
            // When used in trial mode, the library imposes some restrictions.
            // Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            // for more information.

            string pathToFile = "SetPassword.pdf";

            using (PdfDocument pdf = new PdfDocument())
            {
                pdf.UserPassword = "test";

                pdf.Save(pathToFile);
            }

            Process.Start(pathToFile);
        }
    }
}