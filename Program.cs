string[] Fillarray(string  text) {
    System.Console.WriteLine(text);
    string[] array = Console.ReadLine()!.Split();
    return array;}

string[] Result (string[] words) {
    int counter = 0;
    string[] res = new string[words.Length];

    for (int i = 0; i < words.Length; i++){
        foreach (char x in words[i]) {
            counter++;
        }
        if (counter < 4) {
            res[i] = words[i];
            }
        counter = 0;
    }
    return res;
    }

void Printarray(string[] arr){
    System.Console.WriteLine("Result: ");
    System.Console.WriteLine(string.Join(" ", arr));}

//-----------------

Printarray(Result(Fillarray("Enter words: ")));
