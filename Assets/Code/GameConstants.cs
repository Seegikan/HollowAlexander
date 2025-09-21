using UnityEngine;

public static class GameConstants
{
    // ?? Subclase para Tags
    public static class Tags
    {
        public const string Player = "Player";
        public const string Enemy = "Enemy";
        public const string Collectible = "Collectible";
        public const string Ground = "Ground";
    }

    // ?? Subclase para Layers
    public static class Layers
    {
        public const int Default = 0;
        public const int TransparentFX = 1;
        public const int IgnoreRaycast = 2;
        public const int Water = 4;
        public const int UI = 5;

        // ?? También puedes usar strings si prefieres
        public const string Player = "Player";
        public const string Enemy = "Enemy";
    }

    // ?? Subclase para Nombres de Escenas
    public static class Scenes
    {
        public const string MainMenu = "MainMenu";
        public const string Level1 = "Level1";
        public const string Level2 = "Level2";
        public const string GameOver = "GameOver";
    }

    // ?? Subclase para Estados de Animación (opcional)
    public static class Animations
    {
        public const string Run = "Run";
        public const string Jump = "Jump";
        public const string Attack = "Attack";
        public const string Die = "Die";
    }
}
