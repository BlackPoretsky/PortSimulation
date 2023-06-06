namespace PortSimulation
{
	public partial class Form1 : Form
	{
		Dispatcher dispatcher = new Dispatcher(new Hydrometeorologist());
		List<IFactoryMethodShip> factoryMethods = new List<IFactoryMethodShip>();

		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 6; i++)
			{
				var rand = new Random();
				switch (rand.Next(4))
				{
					case 0:
						dispatcher.AddBerth(new BulkCarriersBerth()); break;
					case 1:
						dispatcher.AddBerth(new TankersBerth()); break;
					case 2:
						dispatcher.AddBerth(new GasCarriersBerth()); break;
					case 3:
						dispatcher.AddBerth(new ContainerCarriersBerth()); break;
				}
			}
			factoryMethods.Add(new BulkCarrierFactory());
			factoryMethods.Add(new TankerFactory());
			factoryMethods.Add(new GasCarriersFactory());
			factoryMethods.Add(new ContainerCarriersFactory());

			await Task.Run(() =>
			{
				while (true)
				{
					dispatcher.Manage();
				}
			});
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var rand = new Random();
			int choice = rand.Next(4);
			ShipState state;
			if (choice % 2 == 0) state = ShipState.Loaded;
			else state = ShipState.Unloaded;
			IFactoryMethodShip factory = factoryMethods[choice];
			dispatcher.AddShip(factory.CreateShip(state));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(dispatcher.raid.m_pTankers.Count.ToString());
		}

	}
}