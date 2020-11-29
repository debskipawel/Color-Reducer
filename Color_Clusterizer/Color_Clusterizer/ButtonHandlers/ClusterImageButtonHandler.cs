﻿using Color_Clusterizer.ExternalDependencies;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Clusterizer
{
    public partial class ColorClusterizer
    {
        private async void ClusterImageButtonHandler(object sender, EventArgs e)
        {
            if (Controller.ClusteredImage is null)
            {
                MessageBox.Show("No image to operate on.");
                return;
            }

            if (Controller.KmeansReport.IsOperating)
            {
                MessageBox.Show("Please wait until the previous calculations are done.");
                return;
            }

            kmeansPictureBox.Image = await Controller.GetKmeansClusteredImage(clusterColorsBar.Value);
        }
    }
}