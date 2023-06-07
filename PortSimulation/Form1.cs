namespace PortSimulation
{
	public partial class Form1 : Form
	{
		Hydrometeorologist hydrometeorologist = new Hydrometeorologist();
		Dispatcher dispatcher;
		List<IFactoryMethodShip> factoryMethods = new List<IFactoryMethodShip>();
		bool worktime = false;

		public Form1()
		{
			InitializeComponent();
			dispatcher = new Dispatcher(hydrometeorologist);
			dispatcher.Notify += Log;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			factoryMethods.Add(new BulkCarrierFactory());
			factoryMethods.Add(new TankerFactory());
			factoryMethods.Add(new GasCarriersFactory());
			factoryMethods.Add(new ContainerCarriersFactory());
		}

		void Log(string? message)
		{
			if (message == null) return;
			richTextBox1.Text += message + '\n';
		}

		private void Stop_Click(object sender, EventArgs e)
		{
			worktime = false;
			dispatcher.Berths.Clear();
			dispatcher.raid.Clear();
			Ship.Next = 0;
			Berth.Next = 0;
			button2.Enabled = false;
			button4.Enabled = true;
		}

		private async void Start_Click(object sender, EventArgs e)
		{
			worktime = true;
			button2.Enabled = true;
			button3.Enabled = false;
			await Task.Run(async () =>
			{
				while (worktime)
				{
					bool prevForecast = hydrometeorologist.WeatherIsClear;
					hydrometeorologist.Forecast();
					if (prevForecast != hydrometeorologist.WeatherIsClear)
					{
						string message = "Hydrometeorologist: ";
						if (hydrometeorologist.WeatherIsClear)
							message += "the weather is clear now";
						else message += "the weather is stormy";
						Log(message);
					}
					await Task.Run(() =>
					{
						var rand = new Random();
						int choice = rand.Next(4);
						ShipState state;
						if (choice % 2 == 0) state = ShipState.Loaded;
						else state = ShipState.Unloaded;
						dispatcher.AddShip(factoryMethods[choice].CreateShip(state));
						Thread.Sleep(500);
					});
					dispatcher.Manage();
					Thread.Sleep(2000);
				}
			});
		}

		private void Init_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = string.Empty;
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
			button4.Enabled = false;
			button3.Enabled = true;
		}
	}
}