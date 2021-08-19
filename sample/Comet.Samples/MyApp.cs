﻿using System;
using Microsoft.Maui.Hosting;

namespace Comet.Samples
{
	public class MyApp : CometApp
	{
		readonly State<int> clickCount = 0;
		readonly State<double> progress = .5;
		readonly State<bool> isToggled = false;
		readonly State<string> textValue = "Test";
		readonly State<TimeSpan> timePickerTime = TimeSpan.FromSeconds(0);
		[Body]
		View view() => new MainPage();
			//new ListView<int>(Enumerable.Range(0,1000).ToList())
			//{
			//	ViewFor = (i) =>  new Text($"Cell: {i}"),
				
			//};
		//	new VStack(spacing: 6)
		//	{
		//		new Text("Welcome to Comet!!!!").Margin(top: 100).Color(Colors.Blue),
		//		// new Image("turtlerock.jpg").Frame(100,100), 
		//		new ShapeView(new Circle().Stroke(Colors.Fuchsia,2)
		//			.Fill(new RadialGradient(new Color[] { Colors.LightGray, Colors.Black}, new Point(.5, .25), 0, 100)))
		//			.Frame(100,100).Padding(2).Background(Colors.White),
		//		new ShapeView(new Shapes.Rectangle().Stroke(Colors.Fuchsia,2)
		//			.Fill(new LinearGradient(new Color[] { Colors.LightGray, Colors.Black}, new Point(0, 0), new Point(1,1))))
		//		.Frame(100,100).Padding(10).Background(Colors.White),
		//		new ShapeView(new Ellipse().Stroke(Colors.Fuchsia,2).Fill(Colors.Blue)).Frame(100,100).Padding(2).Background(Colors.White),
		//		new Text(() => !isToggled ?  "Off" : "Hey I am toggled"),
		//		new Button(()=>  $"I was Clicked: {clickCount}!!!!!",()=>{
		//			clickCount.Value++;
		//		}).Color(Colors.Yellow)
		//			.Background(Colors.Blue),
		//		new ActivityIndicator(),
		//		new CheckBox(isToggled),
		//		new Toggle(isToggled),
		//		new TextEditor(textValue),
		//		new ProgressBar(progress),
		//		new Slider(progress),
		//		new Text(textValue),
		//		new TextField(textValue),
		//		new SecureField(textValue),
		//}.Background(Colors.Beige);

		public override void Configure(IAppHostBuilder appBuilder)
		{
			base.Configure(appBuilder);
#if DEBUG
			appBuilder.EnableHotReload();
#endif

		}
	}
}
