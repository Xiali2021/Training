namespace Training
{
    /// <summary>
    /// Represents a martial art entry used by <c>Program</c>.
    /// The constructor parameters correspond to the positional arguments passed from <c>Program.Main</c>.
    /// </summary>
    internal sealed class KungFu
    {
        public string Name { get; }  // 武功名称
        public string School { get; } // 门派
        public int Power { get; } // 威力
        public int Defense { get; } // 内力消耗
        public int Difficulty { get; } // 难度
        public string Category { get; } // 秘籍类别
        public bool NeedsWeapon { get; } // 是否需要武器

        // Constructor with positional parameters
        public KungFu(string name, string school, int power, int defense, int difficulty, string category, bool needsWeapon)
        {
            Name = name;
            School = school;
            Power = power;
            Defense = defense;
            Difficulty = difficulty;
            Category = category;
            NeedsWeapon = needsWeapon;
        }
    }
}
