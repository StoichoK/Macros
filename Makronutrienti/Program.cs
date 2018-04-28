using System;

namespace Makronutrienti
{
    class Makronutrienti
    {
        static void Main()
        {
            Console.WriteLine("---------------------- Полезна информация:");
            Console.WriteLine("Въглехидрати:");
            Console.WriteLine("- ПРОСТИ *бързи (монозахариди);");
            Console.WriteLine("- СЛОЖНИ *комплексни*бавни (дизахариди, олигозахариди и полизахариди);");
            Console.WriteLine("- фибри.");
            Console.WriteLine();
            Console.WriteLine("Мазнини:");
            Console.WriteLine("- НАСИТЕНИ (отговорни за лошия холестерол - LDL);");
            Console.WriteLine("- НЕНАСИТЕНИ (отговорни за добрия холестерол - HDL и понижават сърдеч. съд. заболявания).");
            Console.WriteLine();
            Console.WriteLine("Протеини:");
            Console.WriteLine("Изградени са от 20 аминокиселини свързани с пептидни връзки,");
            Console.WriteLine("8 от тях не се синтезират от тялото и трябва да се набяват отвън и се наричат НЕЗАМЕНИМИ.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("///// Съвети при съставянето на диети:");
            Console.WriteLine("- да се избягва комбинирането на високи грамажи въгл. и мазн., винаги едното от двете преобладава за сметка на другото;");
            Console.WriteLine("- препоръчително при приема на високи грамажи въгл. е 60-65% от тях да се приемат в началото на деня до преди обяд;");
            Console.WriteLine("- при ден с ниско количество въглехидрат и високо количество протеини е препоръчителен приема на повече мазнини;");
            Console.WriteLine("- съответно при ден с високо количество въглехидрат и високи/ниски протеини, мазнините трябва да са сведени до минимум;");
            Console.WriteLine("- задължителен е приема на повече фибри при нисковъглехидратни диети;");
            Console.WriteLine("- да се вземе предвид, типа тяло на клиета - ЕНДОМОРФ (лесно сваля маса), МЕЗОМОРФ (“златната среда”) или ЕКТОМОРФ (трудно качва маса).");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("///// По-известни видове диети");
            Console.WriteLine("- Въртене на въглехидратите;");
            Console.WriteLine();
            Console.WriteLine("- НВД (нисковъглехидратна);");
            Console.WriteLine();
            Console.WriteLine("- ВВД (високовъглехидратна);");
            Console.WriteLine();
            Console.WriteLine("- диета на Дюкан:");
            Console.WriteLine("  Нискокалорична, предимно протеини и ниско съдържание на мазнини и въглехидрати;");
            Console.WriteLine();
            Console.WriteLine("- КЕТОННА ДИЕТА / КЕТО ДИЕТА (Аткинс диета):");
            Console.WriteLine("  Предимно високи количества на протеини и мазнини и ниски или никакви въглехидрати;");
            Console.WriteLine("  Около 2.5 до 3 и повече гр. протеини на кг. тел. тегло за мъже и 2 до 2.5 гр. за жени;");
            Console.WriteLine("  Приемането на храната да бъде от 6 до 8 порции в деня;");
            Console.WriteLine("  На всеки 5 до 7 дни е препоръчително консумирането за един ден на 1 до 2 гр. въглехидрат на кг. тел. тегло;");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("///// Съотношение в диети - % от общия калориен прием за деня:");
            Console.WriteLine("Протеини   / Въглехидрати / Мазнини");
            Console.WriteLine("==");
            Console.WriteLine("15 - 35%   / 55 - 65%     / 15 - 35%");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("///// Приблизителни количества според дневните нужди:");
            Console.WriteLine("Протеини:");
            Console.WriteLine("- задължителен минимум - 0.8 гр. на кг. телесно тегло;");
            Console.WriteLine("- обикновено спортуващи - от 1.2 до 2 гр. на кг. телесно тегло;");
            Console.WriteLine("- тежки тренировки, за културисти и т.н. - от 2 до 3 гр. и повече.. на кг. телесно тегло.");
            Console.WriteLine();
            Console.WriteLine("Въглехидрати:");
            Console.WriteLine("- за изгаряне на мазнини - около 2-3 гр. на кг. телесно тегло;");
            Console.WriteLine("- за покачване на маса - около 4-5 до 6 гр. и повече на кг. телесно тегло.");
            Console.WriteLine();
            Console.WriteLine("Мазнини:");
            Console.WriteLine("- за изгаряне на мазнини - не повече от 0.5 гр. на кг. телесно тегло;");
            Console.WriteLine("- за покачване на маса - около 0.7 до 1-1.5 гр. на кг. телесно тегло.");
            Console.WriteLine();
            Console.WriteLine("1 гр. въглехидрати == 4 kcal.");
            Console.WriteLine("1 гр. протеини == 4 kcal.");
            Console.WriteLine("1 гр. мазнини == 9 kcal.");
            Console.WriteLine("1 гр. алкохоли == 7 kcal.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------- Пресмятане:");
            Console.Write("Въведете желаното количество грамове протеини за кг. телесно тегло според вашите нужди - ");
            double protGr = double.Parse(Console.ReadLine());
            Console.Write("Въведете желаното количество грамове въглехидрати за кг. телесно тегло според вашите нужди - ");
            double carbGr = double.Parse(Console.ReadLine());
            Console.Write("Въведете желаното количество грамове мазнини за кг. телесно тегло според вашите нужди - ");
            double fatGr = double.Parse(Console.ReadLine());
            Console.Write("Въведете вашите килограми - ");
            double kg = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"///// Кол. прот. за ден -  {Math.Round(kg * protGr)} гр.  =  {(Math.Round(kg * protGr) * 4)} kcal.");
            Console.WriteLine($"///// Кол. въгл. за ден -  {Math.Round(kg * carbGr)} гр.  =  {(Math.Round(kg * carbGr) * 4)} kcal.");
            Console.WriteLine($"///// Кол. мазн. за ден -  {Math.Round(kg * fatGr)} гр.   =  {(Math.Round(kg * fatGr) * 9)} kcal.");

            var resultKcal = (Math.Round(kg * protGr) * 4) + (Math.Round(kg * carbGr) * 4) + (Math.Round(kg * fatGr) * 9);
            var fatPercentFromKcal = Math.Round(((Math.Round(kg * fatGr) * 9) / resultKcal) * 100);
            var carbPercentFromKcal = Math.Round(((Math.Round(kg * carbGr) * 4) / resultKcal) * 100);
            var protPercentFromKcal = Math.Round(((Math.Round(kg * protGr) * 4) / resultKcal) * 100);

            Console.WriteLine();
            Console.WriteLine($"///// Пресмятане на калориите - {resultKcal} kcal. за ден.");
            Console.WriteLine($"///// {protPercentFromKcal} % прот.  /   {carbPercentFromKcal} % въгл.  /   {fatPercentFromKcal} % мазн.");

            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
