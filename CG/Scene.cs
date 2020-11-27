﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace CG
{
    class Scene
    {
        public List<Object> objects;
        public List<Light> lights;

        public Scene()
        {
            this.objects = new List<Object>();
            this.lights = new List<Light>();

        }

        public void SetMajorScene()
        {
            Bitmap texture = Image.FromFile(@"d:\earth.png") as Bitmap;
            double[] eye1 = { 0.05, 0.17, 2.92 };
            double[] eye2 = { -0.05, 0.17, 2.92 };

            double[] nose = { 0, 0.13, 2.92 };

            double[] baseSphere = { 0, -0.5, 3 };
            double[] middleSphere = { 0, -0.1, 3 };
            double[] highSphere = { 0, 0.17, 3 };

            double[] majorSphere = { 0, -0.4, 3 };
            double[] underMajorsphere = { 0, -1.6, 3 };
            double[] plane = { 0, -5001, 0 };
            double[] behindMajorsphere = { 0, 0.2, 5 };

            double[] test = { -2, 1, 3 };
            double[] test1 = { 0, 1.8, 1 };
            double[] test2 = { 0, 5, -4 };

            double[] black = { 0, 0, 0 };
            double[] orange = { 255, 128, 0 };
            double[] snow = { 255, 255, 255 };
            double[] red = { 255, 0, 0 };
            double[] yellow = { 255, 255, 0 };

            double[] color1 = { 254, 239, 210 };
            double[] color2 = { 240, 240, 240 };
            double[] color3 = { 0, 255, 0 };
            double[] color4 = { 255, 255, 0 };

            double[] poslight = { 2, 2, 0 };

            double[] poslight5 = { 2, 2.2, -1 };
            double[] poslight6 = { 2, 2.5, -1 };
            double[] poslight7 = { 2, 2.3, -1 };


            double[] poslight1 = { -1, 1, 3 };

            double[] directionlight = { 0, 0, -2 };
        
            double[][] myTriangle =
            {
                new double[] { -1000, -1, -1000 },
                new double[] { -1000, -1, 1000 },
                new double[] { 1000, -1, 0}
            };


            double[][] myTriangle1 =
            {
                new double[] { 0.91653049, 2.983851, -1.7062331 },
                new double[] { -3.198668, -0.82877064, -1.7062331 },
                new double[] { -3.198668, 2.983851, -1.7062331 }
            };

            double[][] myTriangle2 =
            {
                new double[] { 0.91653049, 2.983851, -1.7062331 },
                new double[] { -3.198668, -0.82877064, -1.7062331 },
                new double[] { 0.91653049, -0.82877064, -1.7062331 }
            };

            double[][] postriangle =
            {
                new double[] { 3, 4, 6 },
                new double[] { -2, 4, 2 },
                new double[] { 0, 4, 0 }
            };

            double[] oldCentre = { 0, -5001, 0 };


            var objects = new List<Object>() { /*new Sphere(oldCentre, 5000, red, 1, 0.5, 0, 0, null),*/
                                               new Sphere(test, 1, red, 1000, 0.3, 0, 0, null),                                                                                          
                                               /*new Sphere(majorSphere, 1, color2, 1000, 0, 1, 1, null),
                                               new Sphere(baseSphere, 0.3, snow, 1000, 0.1, 0, 1, null),
                                               new Sphere(middleSphere, 0.2, snow, 1000, 0.1, 0, 1, null),
                                               new Sphere(highSphere, 0.1, snow, 1000, 0.1, 0, 1, null),
                                               new Sphere(underMajorsphere, 1, color1, 100, 0.01, 0, 1, null),
                                               new Sphere(eye1, 0.025, black, 1000, 0.3, 0, 1, null),
                                               new Sphere(eye2, 0.025, black, 1000, 0.3, 0, 1, null),
                                               new Sphere(nose, 0.025, orange, 1000, 0.3, 0, 1, null),    */
                                               
                                               new Triangle(myTriangle, orange, 0, 0.2, 0, 0, null, 0),

            };

            

            var lights = new List<Light>() { new AmbientLight(0.1), new PointLight(test1, 0.6) /*new LightDisk(test1, 0.7, 0.7) */ 
                };

            this.objects.AddRange(objects);
            this.lights = lights;

        }
    }
}