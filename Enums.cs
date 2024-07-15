namespace Inheritance.DataStructure;

public enum MessageType
{
	Incoming = 0,
	Outgoing = 1,
	Service = 2
}

public enum MessageTopic
{
	Subscribe,
	Error,
	Update
}