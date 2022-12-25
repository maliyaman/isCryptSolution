

using System.Numerics;
using System.Text;

string[] crypt = new string[] { "TEN", "TWO", "ONE" };


char[][] solutionArr = new char[5][];
solutionArr[0] = new char[2] { 'O', '1' };
solutionArr[1] = new char[2] { 'T', '0' };
solutionArr[2] = new char[2] { 'W', '9' };
solutionArr[3] = new char[2] { 'E', '5' };
solutionArr[4] = new char[2] { 'N', '4' };

Console.WriteLine(solution(crypt, solutionArr));

bool solution(string[] crypt, char[][] solution)
{
    bool result = false;

	Dictionary<char, int> solutionDict = solToDict(solution);

    UInt64 res1 = getNum(solutionDict,crypt[0]);
    UInt64 res2 = getNum(solutionDict,crypt[1]);
    UInt64 ans = getNum(solutionDict, crypt[2]);

    if (res1.ToString().Length < crypt[0].Length)
    {

        result = false;

        return result;
    }
    if (res2.ToString().Length < crypt[1].Length)
    {

        result = false;

        return result;
    }

    if (ans.ToString().Length < crypt[2].Length)
    {

        result = false;

        return result;
    }




    if((res1+ res2) == ans)
    {
        result = true;
    }

    return result;
}

UInt64 getNum(Dictionary<char, int> solution,string word)
{
    UInt64 result = 0;
    StringBuilder resStr = new StringBuilder();

    for (int i = 0; i < word.Length; i++)
    {
        int value = 0;
        solution.TryGetValue(word[i],out value);
        resStr.Append(value);
    }

    result = UInt64.Parse(resStr.ToString());

    return result;
}

Dictionary<char,int> solToDict(char[][] solution)
{
    Dictionary<char, int> result = new Dictionary<char, int>();

	for (int i = 0; i < solution.Length; i++)
	{
		result.Add(solution[i][0], Int32.Parse(solution[i][1].ToString()));

    }

	return result;
}