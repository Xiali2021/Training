namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var kungfus = new List<KungFu>
                {
                    new KungFu("九阳真经", "少林", 95, 80, 10, "内功",   false),
                    new KungFu("易筋经", "少林", 90, 85, 10, "内功",   false),
                    new KungFu("大力金刚掌", "少林", 85, 60,  8, "外功",   false),
                    new KungFu("少林七十二绝技", "少林", 88, 70,  9, "外功",   false),
                    new KungFu("罗汉拳", "少林", 55, 30,  4, "拳掌",   false),
                    new KungFu("太极拳", "武当", 85, 40,  7, "拳掌",   false),
                    new KungFu("太极剑", "武当", 82, 45,  7, "剑法",   true),
                    new KungFu("纯阳无极功", "武当", 87, 75,  9, "内功",   false),
                    new KungFu("梯云纵", "武当", 75, 55,  8, "轻功",   false),
                    new KungFu("真武七截阵", "武当", 90, 65,  8, "外功",   false),
                    new KungFu("独孤九剑", "华山", 96, 70,  9, "剑法",   true),
                    new KungFu("葵花宝典", "华山", 99, 85, 10, "暗器",   true),
                    new KungFu("辟邪剑法", "华山", 93, 65,  9, "剑法",   true),
                    new KungFu("华山剑法", "华山", 65, 35,  5, "剑法",   true),
                    new KungFu("紫霞神功", "华山", 78, 60,  7, "内功",   false),
                    new KungFu("降龙十八掌", "丐帮", 92, 75,  9, "外功",   false),
                    new KungFu("打狗棒法", "丐帮", 88, 50,  8, "外功",   true),
                    new KungFu("逍遥游",  "丐帮", 68, 40,  6, "轻功",   false),
                    new KungFu("锁喉擒拿手", "丐帮", 70, 45,  6, "外功",   false),
                    new KungFu("凌波微步", "逍遥派", 70, 60, 8, "轻功",   false),
                    new KungFu("北冥神功", "逍遥派", 93, 95, 10, "内功",  false),
                    new KungFu("小无相功", "逍遥派", 85, 70,  9, "内功",  false),
                    new KungFu("天山折梅手", "逍遥派", 80, 55,  7, "外功",  false),
                    new KungFu("生死符", "逍遥派", 77, 50,  8, "暗器",  false),
                    new KungFu("九阴真经", "峨眉", 94, 80, 10, "内功",   false),
                    new KungFu("峨眉剑法", "峨眉", 72, 40,  6, "剑法",   true),
                    new KungFu("金顶绵掌", "峨眉", 74, 42,  6, "拳掌",   false),
                    new KungFu("佛光普照", "峨眉", 83, 58,  7, "外功",   false),
                    new KungFu("乾坤大挪移", "明教", 91, 78, 10, "内功",   false),
                    new KungFu("圣火令武功", "明教", 84, 60,  8, "外功",   true),
                    new KungFu("七伤拳", "明教", 86, 65,  8, "拳掌",   false),
                    new KungFu("青翼蝠王轻功", "明教", 73, 58,  7, "轻功",   false),
                    new KungFu("玉女心经", "古墓派", 81, 62, 8, "轻功",   false),
                    new KungFu("玉女素心剑", "古墓派", 89, 68, 9, "剑法",   true),
                    new KungFu("冰魄银针", "古墓派", 76, 45, 7, "暗器",   true),
                    new KungFu("天罗地网势", "古墓派", 67, 38, 6, "外功",   false),
                    new KungFu("先天功", "全真教", 88, 72, 9, "内功",   false),
                    new KungFu("全真剑法", "全真教", 69, 36, 5, "剑法",   true),
                    new KungFu("金雁功", "全真教", 66, 48, 6, "轻功",   false),
                    new KungFu("嵩山剑法", "嵩山派", 64, 33, 5, "剑法",   true),
                    new KungFu("大嵩阳神掌", "嵩山派", 71, 44, 6, "拳掌",   false),
                    new KungFu("黯然销魂掌", "杨过", 93, 68, 9, "拳掌",   false),
                    new KungFu("蛤蟆功", "欧阳锋", 83, 60, 8, "外功",  false),
                    new KungFu("弹指神通", "黄药师", 79, 52, 7, "暗器",  false),
                    new KungFu("神行百变", "韦小宝", 58, 35, 5, "轻功",  false),
                    new KungFu("唐诗剑法", "乾隆", 45, 25, 3, "剑法",    true),
                    new KungFu("柴刀十八路", "狄云", 42, 20, 2, "外功",    true)
                };

            // Q1 : 找出所有轻功秘籍 输出名称和门派
            var q1 = kungfus.Where(k => k.Category == "轻功");
            foreach (var k in q1)
            {
                Console.WriteLine($"武功名称: {k.Name} ({k.School})");
            }
            Console.WriteLine("==================================================================");


            // Q2 : 跳过威力前3的绝学神功 输出名称和它的威力值
            var q2 = kungfus.OrderByDescending(e => e.Power).Skip(3);
            foreach (var k in q2)
            {
                Console.WriteLine($"武功名称: {k.Name}(威力: {k.Power})");
            }
            Console.WriteLine("==================================================================");

            // Q3 : 取出所有的内功心法 输出名称和它的难度指数
            var q3 = kungfus.Where(k => k.Category == "内功");
            foreach (var k in q3)
            {
                Console.WriteLine($"武功名称：{k.Name}({k.Difficulty}*)");
            }
            Console.WriteLine("==================================================================");

            // Q4 : 计算每本武功的【性价比=威力/内力消耗】 输出前5名
            var q4 = kungfus.Select(k => new { k.Name, Ratio = (double)k.Power / k.Defense }).Take(5);
            foreach (var item in q4)
            {
                Console.WriteLine($"武功名称：{item.Name}: {item.Ratio:F2}");
            }
            Console.WriteLine("==================================================================");

            // Q5 : 威力排行榜 TOP 5
            var q5 = kungfus.OrderByDescending(k => k.Power).Take(5);
            foreach (var k in q5)
            {
                Console.WriteLine($"武功名称：{k.Name} (威力: {k.Power})");
            }
            Console.WriteLine("==================================================================");

            // Q6 : 修炼难度最高的3本秘籍
            var q6 = kungfus.OrderByDescending(k => k.Difficulty).Take(3);
            foreach (var k in q6)
            {
                Console.WriteLine($"武功名称： {k.Name}(难度: {k.Difficulty})");
            }
            Console.WriteLine("==================================================================");

            // Q7 : 找到第一本剑法
            var q7 = kungfus.First(k => k.Category == "剑法");
            Console.WriteLine($"武功名称：{q7.Name}({q7.School})");
            Console.WriteLine("==================================================================");


            // Q8 : 找到最后一套暗器
            var q8 = kungfus.Last(k => k.Category == "暗器");
            Console.WriteLine($"武功名称： {q8.Name}(门派: {q8.School})");
            Console.WriteLine("==================================================================");

            // Q9 : 找到唯一《九阳真经》
            var q9 = kungfus.Single(k => k.Name == "九阳真经");
            Console.WriteLine($"武功名称： {q9.Name}({q9.School})");
            Console.WriteLine("==================================================================");

            // Q10 : 所有武功威力都>50吗？
            var q10 = kungfus.All(k => k.Power > 50);
            Console.WriteLine(q10);
            Console.WriteLine("==================================================================");

            // Q11 : 所有秘籍都需要武器吗？
            var q11 = kungfus.All(k => k.NeedsWeapon);
            Console.WriteLine(q11);
            Console.WriteLine("==================================================================");

            // Q12 : 内力消耗/难度  比值最高的秘籍
            var q12 = kungfus.OrderByDescending(e => (double)e.Defense / e.Difficulty).First();
            var ratio = (double)q12.Defense / q12.Difficulty;
            Console.WriteLine($"武功名称：{q12.Name} (ratio = {ratio:F2}, internal = {q12.Defense}, difficulty = {q12.Difficulty})");
            Console.WriteLine("==================================================================");

            // Q13 : 威力最高的秘籍
            var q13 = kungfus.MaxBy(e => e.Power);
            Console.WriteLine($"武功名称：{q13?.Name} (Power = {q13?.Power})");
            Console.WriteLine("==================================================================");

            // Q14 : 难度最低的秘籍
            var q14 = kungfus.MinBy(e => e.Difficulty);
            Console.WriteLine($"武功名称： {q14?.Name} (难度: {q14?.Difficulty})");
            Console.WriteLine("==================================================================");

            // Q15 : 少林和武当的武功列表相等吗？
            var shaolin = kungfus.Where(k => k.School == "少林");
            var wuDang = kungfus.Where(k => k.School == "武当");
            var q15 = shaolin.SequenceEqual(wuDang);
            Console.WriteLine(q15);
            Console.WriteLine("==================================================================");

            // Q16 : 按照门派分组，输出每个门派的武功数量
            var q16 = kungfus.GroupBy(k => k.School);
            foreach (var group in q16)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            Console.WriteLine("==================================================================");

            // Q17 : 按照类别分组，输出每个类别的武功平均威力
            var q17 = kungfus.GroupBy(k => k.Category)
                            .Select(g => new { Category = g.Key, AvgPower = g.Average(k => k.Power) });
            foreach (var item in q17)
            {
                Console.WriteLine($"{item.Category}: {item.AvgPower:F2}");
            }
            Console.WriteLine("==================================================================");

            // Q18 : 找出所有包含 "剑" 字的武功名称
            var q18 = kungfus.Where(k => k.Name.Contains("剑"));
            foreach (var k in q18)
            {
                Console.WriteLine($"武功名称：{k.Name} ({k.School})");

            }
            Console.WriteLine("==================================================================");

            // Q19 : 江湖上是否存在威力 > 95 的邪门武功 ? 古墓派是否已经失传（还有传人吗）？
            var q19_1 = kungfus.Any(k => k.Power > 95);
            Console.WriteLine(q19_1);

            var tomb = kungfus.Where(k => k.School == "古墓派");
            bool isExtinct = !tomb.Any();
            Console.WriteLine(isExtinct);
            Console.WriteLine("==================================================================");
        }
    }
}
