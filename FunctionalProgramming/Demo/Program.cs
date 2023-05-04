
//Записваме функции () в променливи.Тази функция може да е воид, която да печата нещо
var lambda = () => Console.WriteLine("Hello"); // Това всъщност е референция към функция. Променливата lambda сочи към функция. Когато е воид задължително има ()

// Може да сочи функция(метод), който предварително сме си генерирали
var lambda2 = Hello;
static void Hello()
{
    Console.WriteLine("Hello from method");
}
//След като вече сме ги декларирали ги извикваме ги виждаме че сработва на конзолата
lambda();
lambda2();


// Типа данни на променлива, която сочи към воид функция е Action
//Action lambda = () => Console.WriteLine("Hello");
//Типа данни на променливи, сочещи функция(метод), който връща резултат се наричат Func
Func<int> returnInt = () => 5 + 5;
// или
Func<int> returnInt2 = () =>
{
    return 5 + 5;
};

//  става и така:
Func<int> returnInt3 = ReturnInt;
static int ReturnInt()
{
    return 5 + 5;
}
int[] numbers = Console.ReadLine().Split().Select((string x) =>
{
    return int.Parse(x);
})
    .ToArray();

Array.ForEach(numbers, x => // Foreach приема масива числа и приема какъв метод(функция) да изпълни за всяко число
{
    Console.WriteLine(x);
});