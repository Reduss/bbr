using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_bbr.src.components
{
    internal class TestComponent : Component
    {
        public override void Init()
        {
            throw new NotImplementedException();
        }
        public override void Update(float dt)
        {
            throw new NotImplementedException();
        }
        public override void Render()
        {
            // у декяких компонентів рендер/абдейт або ініт можуть можуть не потребувати логіки -- най так буде.
            // це не круто з точки ЧИСТОГО КОДА АОА, але нам підійде
        }

    }
}
