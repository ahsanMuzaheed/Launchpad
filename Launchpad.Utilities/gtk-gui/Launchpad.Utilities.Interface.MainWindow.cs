
// This file has been generated by the GUI designer. Do not modify.

using Gdk;
using Gtk;
using Stetic;

namespace Launchpad.Utilities.Interface
{
	public sealed partial class MainWindow
	{
		private UIManager UIManager;

		private VBox vbox3;

		private MenuBar menubar1;

		private Alignment alignment14;

		private FileChooserWidget fileChooser;

		private Alignment alignment12;

		private HSeparator hseparator3;

		private HBox hbox4;

		private Alignment alignment18;

		private Label label4;

		private Alignment alignment19;

		private Label progressLabel;

		private Alignment alignment17;

		private ProgressBar progressbar;

		private HBox hbox3;

		private Alignment alignment15;

		private Button generateGameManifestButton;

		private Alignment alignment1;

		private Button generateLaunchpadManifestButton;

		private void Build ()
		{
			Gui.Initialize (this);
			// Widget Launchpad.Utilities.Interface.MainWindow
			UIManager = new UIManager ();
			ActionGroup w1 = new ActionGroup ("Default");
			UIManager.InsertActionGroup (w1, 0);
			AddAccelGroup (UIManager.AccelGroup);
			WidthRequest = 640;
			HeightRequest = 384;
			Name = "Launchpad.Utilities.Interface.MainWindow";
			Title = LocalizationCatalog.GetString ("Launchpad Utilities - Manifest");
			Icon = Pixbuf.LoadFromResource ("Launchpad.Utilities.Resources.Icons8-Android-Industry-Engineering.ico");
			WindowPosition = (WindowPosition)4;
			// Container child Launchpad.Utilities.Interface.MainWindow.Gtk.Container+ContainerChild
			vbox3 = new VBox
			{
				Name = "vbox3",
				Spacing = 6
			};
			// Container child vbox3.Gtk.Box+BoxChild
			UIManager.AddUiFromString ("<ui><menubar name='menubar1'/></ui>");
			menubar1 = (MenuBar)(UIManager.GetWidget ("/menubar1"));
			menubar1.Name = "menubar1";
			vbox3.Add (menubar1);
			Box.BoxChild w2 = (Box.BoxChild)vbox3 [menubar1];
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			alignment14 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment14",
				LeftPadding = 8,
				RightPadding = 8
			};
			// Container child alignment14.Gtk.Container+ContainerChild
			fileChooser = new FileChooserWidget((FileChooserAction) 2)
			{
				Name = "fileChooser",
				LocalOnly = false
			};
			alignment14.Add (fileChooser);
			vbox3.Add (alignment14);
			Box.BoxChild w4 = (Box.BoxChild)vbox3 [alignment14];
			w4.Position = 1;
			// Container child vbox3.Gtk.Box+BoxChild
			alignment12 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment12"
			};
			// Container child alignment12.Gtk.Container+ContainerChild
			hseparator3 = new HSeparator
			{
				Name = "hseparator3"
			};
			alignment12.Add (hseparator3);
			vbox3.Add (alignment12);
			Box.BoxChild w6 = (Box.BoxChild)vbox3 [alignment12];
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			hbox4 = new HBox
			{
				Name = "hbox4",
				Spacing = 6
			};
			// Container child hbox4.Gtk.Box+BoxChild
			alignment18 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment18",
				LeftPadding = 8
			};
			// Container child alignment18.Gtk.Container+ContainerChild
			label4 = new Label
			{
				Name = "label4",
				LabelProp = LocalizationCatalog.GetString("Progress: ")
			};
			alignment18.Add (label4);
			hbox4.Add (alignment18);
			Box.BoxChild w8 = (Box.BoxChild)hbox4 [alignment18];
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			alignment19 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment19",
				RightPadding = 8
			};
			// Container child alignment19.Gtk.Container+ContainerChild
			progressLabel = new Label
			{
				Name = "progressLabel",
				LabelProp = LocalizationCatalog.GetString("/some/file/path : 1 out of 100")
			};
			alignment19.Add (progressLabel);
			hbox4.Add (alignment19);
			Box.BoxChild w10 = ((Box.BoxChild)(hbox4 [alignment19]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			vbox3.Add (hbox4);
			Box.BoxChild w11 = (Box.BoxChild)vbox3 [hbox4];
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			alignment17 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment17",
				LeftPadding = 8,
				RightPadding = 8
			};
			// Container child alignment17.Gtk.Container+ContainerChild
			progressbar = new ProgressBar
			{
				Name = "progressbar"
			};
			alignment17.Add (progressbar);
			vbox3.Add (alignment17);
			Box.BoxChild w13 = (Box.BoxChild)vbox3 [alignment17];
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			hbox3 = new HBox
			{
				Name = "hbox3",
				Spacing = 6
			};
			// Container child hbox3.Gtk.Box+BoxChild
			alignment15 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment15",
				RightPadding = 8,
				BottomPadding = 8
			};
			// Container child alignment15.Gtk.Container+ContainerChild
			generateGameManifestButton = new Button
			{
				CanFocus = true,
				Name = "generateGameManifestButton",
				UseUnderline = true,
				Label = LocalizationCatalog.GetString("Generate Game Manifest")
			};
			alignment15.Add (generateGameManifestButton);
			hbox3.Add (alignment15);
			Box.BoxChild w15 = (Box.BoxChild)hbox3 [alignment15];
			w15.PackType = (PackType)1;
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			alignment1 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment1",
				RightPadding = 8,
				BottomPadding = 8
			};
			// Container child alignment1.Gtk.Container+ContainerChild
			generateLaunchpadManifestButton = new Button
			{
				CanFocus = true,
				Name = "generateLaunchpadManifestButton",
				UseUnderline = true,
				Label = LocalizationCatalog.GetString("Generate Launchpad Manifest")
			};
			alignment1.Add (generateLaunchpadManifestButton);
			hbox3.Add (alignment1);
			Box.BoxChild w17 = ((Box.BoxChild)(hbox3 [alignment1]));
			w17.PackType = ((PackType)(1));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			vbox3.Add (hbox3);
			Box.BoxChild w18 = ((Box.BoxChild)(vbox3 [hbox3]));
			w18.Position = 5;
			w18.Expand = false;
			w18.Fill = false;
			Add (vbox3);
			if ((Child != null)) {
				Child.ShowAll ();
			}

			this.DefaultWidth = 640;
			this.DefaultHeight = 384;

			this.Show ();

			DeleteEvent += OnDeleteEvent;
			generateLaunchpadManifestButton.Clicked += OnGenerateLaunchpadManifestButtonClicked;
			generateGameManifestButton.Clicked += OnGenerateGameManifestButtonClicked;
		}
	}
}