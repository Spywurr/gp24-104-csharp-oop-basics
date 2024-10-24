using P2_2ItemValues;

Item i1 = new Item();
i1.goldValue = 100;

Item i2 = new Item();
i2.goldValue = 200;

Item i3 = new Item();
i3.goldValue = 300;

int[] Items = new int[3];
Items[0] = i1.goldValue;
Items[1] = i2.goldValue;
Items[2] = i3.goldValue;

for (int i = 0; i < Items.Length; i++)
{
    Console.WriteLine(Items[i]);
}
