//================================
//  By: Adsolution
//================================
using System.Collections.Generic;
using UnityEngine;

namespace RaymapGame.Rayman2.Persos {
    /// <summary>
    /// Intro Grate
    /// </summary>
    public partial class SUN_Grille_Cine : Ptite_grille {
        protected override void OnStart() {
            hitPoints = 1;
            SetRule("Default");
        }
        
        protected void Rule_Default() {
            ReceiveProjectiles();
        }
        
        protected override void OnDeath() {
            SFX("ray2_sfx/Atmosphere/CRASH1").Play();
            SetVisibility(false);
            Timers("Die").Start(0.55f, () => {
                Remove();
            });
        }
    }
}