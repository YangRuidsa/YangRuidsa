using ProtoBuf;

using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Fantasy;
using Fantasy.Network.Interface;
using Fantasy.Serialize;
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantOverriddenMember
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CheckNamespace
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8618

namespace Fantasy
{	
	/// <summary>
	///  发送第一个Send消息
	/// </summary>
	[ProtoContract]
	public partial class C2G_HelloFantasy : AMessage, IMessage, IProto
	{
		public static C2G_HelloFantasy Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_HelloFantasy>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_HelloFantasy>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2G_HelloFantasy; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	/// <summary>
	/// 服务器主动发送给客户端的消息
	/// </summary>
	[ProtoContract]
	public partial class G2C_HelloFantasy : AMessage, IMessage, IProto
	{
		public static G2C_HelloFantasy Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_HelloFantasy>();
		}
		public override void Dispose()
		{
			tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_HelloFantasy>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_HelloFantasy; }
		[ProtoMember(1)]
		public string tag { get; set; }
	}
	/// <summary>
	/// call消息
	/// </summary>
	[ProtoContract]
	public partial class C2G_HelloFantasyRequest : AMessage, IRequest, IProto
	{
		public static C2G_HelloFantasyRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_HelloFantasyRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_HelloFantasyRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_HelloFantasyResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_HelloFantasyRequest; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class G2C_HelloFantasyResponse : AMessage, IResponse, IProto
	{
		public static G2C_HelloFantasyResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_HelloFantasyResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_HelloFantasyResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_HelloFantasyResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2G_TestMessage : AMessage, IMessage, IProto
	{
		public static C2G_TestMessage Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_TestMessage>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_TestMessage>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2G_TestMessage; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class C2G_TestRequest : AMessage, IRequest, IProto
	{
		public static C2G_TestRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_TestRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_TestRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_TestResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_TestRequest; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class G2C_TestResponse : AMessage, IResponse, IProto
	{
		public static G2C_TestResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_TestResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_TestResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_TestResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2G_CreateAddressableRequest : AMessage, IRequest, IProto
	{
		public static C2G_CreateAddressableRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_CreateAddressableRequest>();
		}
		public override void Dispose()
		{
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_CreateAddressableRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_CreateAddressableResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_CreateAddressableRequest; }
	}
	[ProtoContract]
	public partial class G2C_CreateAddressableResponse : AMessage, IResponse, IProto
	{
		public static G2C_CreateAddressableResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_CreateAddressableResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_CreateAddressableResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_CreateAddressableResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
	[ProtoContract]
	public partial class C2M_TestMessage : AMessage, IAddressableRouteMessage, IProto
	{
		public static C2M_TestMessage Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2M_TestMessage>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2M_TestMessage>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2M_TestMessage; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class C2M_TestRequest : AMessage, IAddressableRouteRequest, IProto
	{
		public static C2M_TestRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2M_TestRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2M_TestRequest>(this);
#endif
		}
		[ProtoIgnore]
		public M2C_TestResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2M_TestRequest; }
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class M2C_TestResponse : AMessage, IAddressableRouteResponse, IProto
	{
		public static M2C_TestResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<M2C_TestResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<M2C_TestResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.M2C_TestResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
	/// <summary>
	///  通知Gate服务器创建一个Chat的Route连接
	/// </summary>
	[ProtoContract]
	public partial class C2G_CreateChatRouteRequest : AMessage, IRequest, IProto
	{
		public static C2G_CreateChatRouteRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2G_CreateChatRouteRequest>();
		}
		public override void Dispose()
		{
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2G_CreateChatRouteRequest>(this);
#endif
		}
		[ProtoIgnore]
		public G2C_CreateChatRouteResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2G_CreateChatRouteRequest; }
	}
	[ProtoContract]
	public partial class G2C_CreateChatRouteResponse : AMessage, IResponse, IProto
	{
		public static G2C_CreateChatRouteResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<G2C_CreateChatRouteResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<G2C_CreateChatRouteResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.G2C_CreateChatRouteResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
	/// <summary>
	///  发送一个Route消息给Chat
	/// </summary>
	[ProtoContract]
	public partial class C2Chat_TestMessage : AMessage, ICustomRouteMessage, IProto
	{
		public static C2Chat_TestMessage Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2Chat_TestMessage>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2Chat_TestMessage>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.C2Chat_TestMessage; }
		[ProtoIgnore]
		public int RouteType => Fantasy.RouteType.ChatRoute;
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	/// <summary>
	///  发送一个RPCRoute消息给Chat
	/// </summary>
	[ProtoContract]
	public partial class C2Chat_TestMessageRequest : AMessage, ICustomRouteRequest, IProto
	{
		public static C2Chat_TestMessageRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2Chat_TestMessageRequest>();
		}
		public override void Dispose()
		{
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2Chat_TestMessageRequest>(this);
#endif
		}
		[ProtoIgnore]
		public Chat2C_TestMessageResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2Chat_TestMessageRequest; }
		[ProtoIgnore]
		public int RouteType => Fantasy.RouteType.ChatRoute;
		[ProtoMember(1)]
		public string Tag { get; set; }
	}
	[ProtoContract]
	public partial class Chat2C_TestMessageResponse : AMessage, ICustomRouteResponse, IProto
	{
		public static Chat2C_TestMessageResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<Chat2C_TestMessageResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
			Tag = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<Chat2C_TestMessageResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.Chat2C_TestMessageResponse; }
		[ProtoMember(1)]
		public string Tag { get; set; }
		[ProtoMember(2)]
		public uint ErrorCode { get; set; }
	}
	/// <summary>
	///  发送一个RPC消息给Map，让Map里的Entity转移到另外一个Map上
	/// </summary>
	[ProtoContract]
	public partial class C2M_MoveToMapRequest : AMessage, IAddressableRouteRequest, IProto
	{
		public static C2M_MoveToMapRequest Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<C2M_MoveToMapRequest>();
		}
		public override void Dispose()
		{
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<C2M_MoveToMapRequest>(this);
#endif
		}
		[ProtoIgnore]
		public M2C_MoveToMapResponse ResponseType { get; set; }
		public uint OpCode() { return OuterOpcode.C2M_MoveToMapRequest; }
	}
	[ProtoContract]
	public partial class M2C_MoveToMapResponse : AMessage, IAddressableRouteResponse, IProto
	{
		public static M2C_MoveToMapResponse Create(Scene scene)
		{
			return scene.MessagePoolComponent.Rent<M2C_MoveToMapResponse>();
		}
		public override void Dispose()
		{
			ErrorCode = default;
#if FANTASY_NET || FANTASY_UNITY
			GetScene().MessagePoolComponent.Return<M2C_MoveToMapResponse>(this);
#endif
		}
		public uint OpCode() { return OuterOpcode.M2C_MoveToMapResponse; }
		[ProtoMember(1)]
		public uint ErrorCode { get; set; }
	}
}
