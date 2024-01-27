using Godot;
using System;

public partial class TextureButton : Godot.TextureButton
{

    bool newspaperHeld = false;
    public override void _Ready()
    {
        base._Ready();

        //var button = new TextureButton();
        //Texture2D texture = new Texture2D();
        //texture.Set("res://sprites/microgame/newspaper_game/newspaper.png");
        //button.TextureNormal = load

        GD.Print("Hello World!");

        this.ButtonDown += newspaperClicked;
        this.ButtonUp += newspaperReleased;

    }

    public override void _Process(double delta)
    {
        base._Process(delta);

        if (newspaperHeld)
        {
            GD.Print("Moving Newspaper");
            this.GlobalPosition = this.GlobalPosition.Lerp(GetGlobalMousePosition(), (float) (25 * delta));
        }
    }

    public void newspaperClicked()
    {
        newspaperHeld = true;
    }

    public void newspaperReleased() {
        newspaperHeld = false;
    }

}
