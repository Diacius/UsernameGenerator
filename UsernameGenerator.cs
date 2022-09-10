class GenerateUserName
{
	static void Main(string[] args){
		Console.WriteLine("DBG: Args length " + args.Length);
		if (args.Length == 2) {
			var firstName = args[0];
			var secondName = args[1];
			string fullname = firstName + " " + secondName;
			string username = firstName.ToLower().ToArray()[0] + "." + secondName.ToLower();
			string email = username + "@proto.biz";
			Console.WriteLine("Full Name:\t" + fullname);
			Console.WriteLine("Username:\t" + username);
			Console.WriteLine("Email:\t\t" + email);
			using (StreamWriter outputFile = new StreamWriter(username + ".txt")) {
					outputFile.WriteLine(fullname);
					outputFile.WriteLine(username);
					outputFile.WriteLine(email);
			}	
		}
		if (args.Length > 2) {
			Console.WriteLine("Too many arguments");
			Console.WriteLine("Usage: usernamegenerator <firstname> <secondname>");
		}
		if (args.Length < 2) {
			Console.WriteLine("You did not provide a name");
			Console.WriteLine("Usage: usernamegenerator <firstname> <secondname>");
		}
		

	}
}