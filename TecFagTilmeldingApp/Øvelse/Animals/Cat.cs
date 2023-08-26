using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Øvelse.Animals;

internal class Cat : Animal
{
    public override string MakeSound()
    {
        string myCurrentDer = System.IO.Directory.GetCurrentDirectory();
        string appDir = System.IO.Path.Combine(myCurrentDer, "Øvelse");
        appDir = System.IO.Path.Combine(appDir, "Animals");
        appDir = System.IO.Path.Combine(appDir, "cat.wav");

        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        soundPlayer.SoundLocation = appDir;
        soundPlayer.Play();

        return "You have choosen a cat.";
    }
}
