using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Particle
{
    public Point Position { get; set; }
    public Point Velocity { get; set; }
    public Color Color { get; set; }
    public int Size { get; set; }

    public Particle(int x, int y)
    {
        Position = new Point(x, y);
        Velocity = new Point(new Random().Next(-2, 3), new Random().Next(-2, 3));
        Color = Color.FromArgb(100, 255, 255, 255); // Cor semi-transparente
        Size = new Random().Next(5, 15);
    }

    public Point GetPosition()
    {
        return Position;
    }

    public Point GetPosition2()
    {
        return Position;
    }

    public Point GetVelocity()
    {
        return Velocity;
    }

    public Point GetVelocity2()
    {
        return Velocity;
    }

    public void Update(Point position, Point position2, Point velocity, Point velocity2)
    {
        position.X += Velocity.X;
        position2.Y += Velocity.Y;

        // Repare que as partículas "rebaterão" nas bordas do formulário
        if (Position.X < 0 || Position.X > 800) velocity.X = -Velocity.X;
        if (Position.Y < 0 || Position.Y > 600) velocity2.Y = -Velocity.Y;
    }
}