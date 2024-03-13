using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_bbr.src
{
    internal abstract class Component
    {
        public bool IsActive { get; set; } = true;
        public bool IsRenderable { get; set; } = true;
        public Entity? Owner { get; set; } = null; // ентіті-власник компоненту

        public abstract void Init();
        public abstract void Update(float dt);
        public abstract void Render();    
    }
}
