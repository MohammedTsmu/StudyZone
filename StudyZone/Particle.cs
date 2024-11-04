using System;
using System.Drawing;

public class Particle
{
    public PointF Position { get; set; }       // Current position
    public PointF Velocity { get; set; }       // Movement per update
    public float Size { get; set; }            // Size of the particle
    public float Life { get; set; }            // Remaining life in seconds
    public float MaxLife { get; set; }         // Maximum life in seconds
    public Color Color { get; set; }           // Color of the particle

    private static Random rand = new Random();

    public Particle(PointF position)
    {
        Position = position;
        Velocity = new PointF(
            (float)(rand.NextDouble() - 0.5) * 2f,  // Random X velocity
            (float)(-rand.NextDouble() * 1f - 1f)   // Upward Y velocity
        );
        Size = rand.Next(2, 6);                     // Random size between 2 and 5
        Life = MaxLife = (float)rand.NextDouble() * 1f + 0.5f; // Life between 0.5 and 1.5 seconds
        Color = Color.FromArgb(255, 255, 255, 255);  // White color
    }

    public void Update(float deltaTime)
    {
        // Update position
        Position = new PointF(
            Position.X + Velocity.X * deltaTime * 60f,
            Position.Y + Velocity.Y * deltaTime * 60f
        );

        // Decrease life
        Life -= deltaTime;

        // Ensure Life does not go below zero
        if (Life < 0)
        {
            Life = 0;
        }

        // Fade out
        float lifeRatio = Life / MaxLife;
        int alpha = (int)(lifeRatio * 255);

        // Clamp alpha between 0 and 255
        alpha = Math.Max(0, Math.Min(255, alpha));

        Color = Color.FromArgb(alpha, Color.R, Color.G, Color.B);
    }
}
