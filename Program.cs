class Homework {
    static void Main(string[] args){

Console.WriteLine("ป้อนรหัสผ่าน 6 ตัว:");
int password = int.Parse(Console.ReadLine());

Console.WriteLine("ป้อนตัวย่อหน่วยงานของคุณ (FBI, CIA หรือ NSA):");
string agencyAbbreviation = Console.ReadLine();
bool isPasswordValid = false;

        int digit = password % 10;      
        int tens = password % 10 /10;     
        int hundreds = (password / 100) % 10;                                                                    
        int thousands = password % 10000 /1000;
        int tensofthousands = (password / 10000) % 10;
        int Hundredthousand = password % 1000000 /100000;
switch (agencyAbbreviation)
{
  
    case "CIA":
        if(
            digit % 3 ==0 && tens !=1 && tens !=3 && tens !=5 && thousands >6 && thousands !=8
        ){
        isPasswordValid = true;

        }
                    Console.WriteLine(isPasswordValid);

        break;
    case "FBI":        
        if(
            Hundredthousand >= 4 && Hundredthousand <=7 && hundreds % 2 == 0 && hundreds !=6
            && tensofthousands == 1  && tensofthousands == 3    && tensofthousands == 5
            && tensofthousands == 7  && tensofthousands == 9
        ){
        isPasswordValid = true;

        }
                    Console.WriteLine(isPasswordValid);

        break;
    case "NSA":
        int countpassword = password;
        string passcode = password.ToString();
        if(
           digit  == 0 || digit == 2 || digit == 3 || digit == 5 || digit == 6
           && hundreds % 2 !=0 && hundreds % 3 == 0 )


        for (int i = 0; i < passcode.Length; i++) 
            if (passcode[i] == '7')
        {
        isPasswordValid = true;

        }
                    Console.WriteLine(isPasswordValid);

        break;
    default:
        Console.WriteLine("รหัสผ่านไม่ถูกต้อง");
        break;
}
}
}