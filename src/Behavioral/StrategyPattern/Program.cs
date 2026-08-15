using DesignPatterns.Behavioral.StrategyPattern;

Duck mallard = new MallardDuck();

Console.WriteLine("========== Mallard Duck ==========");
mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();
mallard.Swim();

Console.WriteLine();

Duck rubber = new RubberDuck();

Console.WriteLine("========== Rubber Duck ==========");
rubber.Display();
rubber.PerformFly();
rubber.PerformQuack();
rubber.Swim();

Console.WriteLine();

Duck decoy = new DecoyDuck();

Console.WriteLine("========== Decoy Duck ==========");
decoy.Display();
decoy.PerformFly();
decoy.PerformQuack();
decoy.Swim();

Console.WriteLine();

Console.WriteLine("========== Change Behavior At Runtime ==========");

// 執行期間動態更換飛行策略
rubber.SetFlyBehavior(new FlyRocketPowered());

rubber.Display();
rubber.PerformFly();
rubber.PerformQuack();