using System;
using System.Collections.Generic;

namespace MegaDesk_Cirks
{
    // DeskMaterial enum
    public enum DeskMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }

    internal class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DeskMaterial SurfaceMaterial { get; set; }

        public Desk() { }

        public Desk(int width, int depth, int numDrawers, DeskMaterial surfaceMaterial)
        {
            Width = width;
            Depth = depth;
            NumDrawers = numDrawers;
            SurfaceMaterial = surfaceMaterial;
        }

        public int GetSurfaceArea()
        {
            return Width * Depth;
        }

        public bool IsValid()
        {
            if (Width < 24 || Width > 96)
            {
                return false;
            }
            if (Depth < 12 || Depth > 48)
            {
                return false;
            }
            if (NumDrawers < 0 || NumDrawers > 7)
            {
                return false;
            }
            if (SurfaceMaterial != DeskMaterial.Oak && 
                SurfaceMaterial != DeskMaterial.Laminate && 
                SurfaceMaterial != DeskMaterial.Pine && 
                SurfaceMaterial != DeskMaterial.Rosewood && 
                SurfaceMaterial != DeskMaterial.Veneer)
            {
                return false;
            }
            return true;
        }
    }
}
