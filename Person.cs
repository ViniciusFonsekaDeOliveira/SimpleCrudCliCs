using System;

public class Person
{
	public string Uuid { get; set; }
	public string Firstname { get; set; }
	public string Lastname { get; set; }
	public string Nickname { get; set; }
	public string Email { get; set; }

	public Person(string uuid, string firstname, string lastname, string nickname, string email)
	{
		Uuid = uuid;
		Firstname = firstname;
		Lastname = lastname;
		Nickname = nickname;
		Email = email;
	}

	public Person(string firstname, string lastname, string nickname, string email)
	{
		Uuid = Guid.NewGuid().ToString();
		Firstname = firstname;
		Lastname = lastname;
		Nickname = nickname;
		Email = email;
	}

	public override string ToString()
	{
		return ($"Person\n" +
			$"{nameof(Uuid)}: {Uuid}\n" +
			$"{nameof(Firstname)}: {Firstname}\n" +
			$"{nameof(Lastname)}: {Lastname}\n" +
			$"{nameof(Nickname)}: {Nickname}\n" +
			$"{nameof(Email)}: {Email}");
	}

	public Dictionary<string, string> ToDict()
	{
		Dictionary<string, string> personToDict = new()
		{
			{ nameof(Uuid), Uuid },
			{ nameof(Firstname), Firstname },
			{ nameof(Lastname), Lastname },
			{ nameof(Nickname), Nickname },
			{ nameof(Email), Email }
		};
		return personToDict;
	}
}
