using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class PaintBallGunOffense : PaintBallGunBase
	{
		[Constructable]
		public PaintBallGunOffense()
		{
			Name = "Paint Ball Gun (Offense)";
			Attributes.DefendChance = -25;
			Attributes.AttackChance = 25;
		}

		public PaintBallGunOffense( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}