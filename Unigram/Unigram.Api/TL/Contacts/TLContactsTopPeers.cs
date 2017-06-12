// <auto-generated/>
using System;

namespace Telegram.Api.TL.Contacts
{
	public partial class TLContactsTopPeers : TLContactsTopPeersBase 
	{
		public TLVector<TLTopPeerCategoryPeers> Categories { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }

		public TLContactsTopPeers() { }
		public TLContactsTopPeers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsTopPeers; } }

		public override void Read(TLBinaryReader from)
		{
			Categories = TLFactory.Read<TLVector<TLTopPeerCategoryPeers>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x70B772A8);
			to.WriteObject(Categories);
			to.WriteObject(Chats);
			to.WriteObject(Users);
		}
	}
}