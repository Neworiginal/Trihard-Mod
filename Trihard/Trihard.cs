using Terraria.ModLoader;

namespace Trihard
{
    public class Trihard : Mod
    {
      
        public Trihard()
        {

            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true

            };
        }
    }
}
