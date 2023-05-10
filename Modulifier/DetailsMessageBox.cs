using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Text.RegularExpressions;

namespace Modulifier
{
    /// <summary>
    /// Message box with the ability to expand and show details.
    /// </summary>
    public partial class DetailsMessageBox : Form
    {
        public string Caption { get => Text; set => Text = value; }
        public string Body { get => msgText.Text; set => msgText.Text = value; }
        public Bitmap MessageIcon { get => (Bitmap)icon.Image; set => icon.Image = value; }
        public string Details { get => details.Text; set => details.Text = value; }

        /// <summary>
        /// Creates an instance of DetailsMessageBox with the specified owner and contents.
        /// </summary>
        /// <param name="owner">Owner of this window.</param>
        /// <param name="caption">Title of the window.</param>
        /// <param name="text">Text, shown in the main box.</param>
        /// <param name="details">Text, shown in the details box.</param>
        /// <param name="icon">Icon, shown in the main box.</param>
        public DetailsMessageBox(IWin32Window owner, string caption, string text, string details, Bitmap? icon = null)
        {
            InitializeComponent();

            Text = caption;
            msgText.Text = text;
            this.details.Text = details;
            this.icon.Image = icon;
            Owner = (Form)owner;
        }

        /// <summary>
        /// Creates and shows an instance of DetailsMessageBox with the specified owner and contents. When closed, <see cref="Component.Dispose(bool)">disposes</see> the created dialog instance.
        /// </summary>
        /// <param name="owner">Owner of the window.</param>
        /// <param name="caption">Title of the window.</param>
        /// <param name="text">Text, shown in the main box.</param>
        /// <param name="details">Text, shown in the details box.</param>
        /// <param name="icon">Icon, shown in the main box.</param>
        /// <returns>Clicked button. Close (red X, system menu, ALT+F4, Quit): <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.Cancel">Cancel</see>, OK: <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.OK">OK</see>.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="DetailsMessageBox">DetailsMessageBox</see> is already shown.</exception>
        public static DialogResult ShowDialog(IWin32Window owner, string caption, string text, string details, Bitmap icon)
        {
            var d = new DetailsMessageBox(owner, caption, text, details, icon);
            var r = d.ShowDialog();
            d.Dispose(true);
            return r;
        }

        /// <summary>
        /// Creates and shows an instance of DetailsMessageBox with the specified owner and contents. When closed, <see cref="Component.Dispose(bool)">disposes</see> the created dialog instance. This method is equal to <see cref="ShowDialog(IWin32Window, string, string, string, Bitmap)">ShowDialog</see>.
        /// </summary>
        /// <param name="owner">Owner of the window.</param>
        /// <param name="caption">Title of the window.</param>
        /// <param name="text">Text, shown in the main box.</param>
        /// <param name="details">Text, shown in the details box.</param>
        /// <param name="icon">Icon, shown in the main box.</param>
        /// <returns>Clicked button. Close (red X, system menu, ALT+F4, Quit): <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.Cancel">Cancel</see>, OK: <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.OK">OK</see>.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="DetailsMessageBox">DetailsMessageBox</see> is already shown.</exception>
        public static DialogResult Show(IWin32Window owner, string caption, string text, string details, Bitmap icon) =>
            ShowDialog(owner, caption, text, details, icon);

        /// <summary>
        /// Shows this instance of DetailsMessageBox.
        /// </summary>
        /// <returns>Clicked button. Close (red X, system menu, ALT+F4, Quit): <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.Cancel">Cancel</see>, OK: <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.OK">OK</see>.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="DetailsMessageBox">DetailsMessageBox</see> is already shown.</exception>
        new public DialogResult ShowDialog()
        {
            if (Visible) throw new InvalidOperationException("This instance of DetailsMessageBox is already visible.");
            return base.ShowDialog();
        }

        /// <summary>
        /// Shows this instance of DetailsMessageBox with a new owner.
        /// </summary>
        /// <param name="owner">New owner.</param>
        /// <returns>Clicked button. Close (red X, system menu, ALT+F4, Quit): <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.Cancel">Cancel</see>, OK: <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.OK">OK</see>.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="DetailsMessageBox">DetailsMessageBox</see> is already shown.</exception>
        new public DialogResult ShowDialog(IWin32Window owner)
        {
            if (Visible) throw new InvalidOperationException("This instance of DetailsMessageBox is already visible.");

            Owner = (Form)owner;
            return ShowDialog();
        }

        /// <summary>
        /// Shows this instance of DetailsMessageBox. This method is equal to <see cref="DetailsMessageBox.ShowDialog()">ShowDialog</see>.
        /// </summary>
        /// <returns>Clicked button. Close (red X, system menu, ALT+F4, Quit): <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.Cancel">Cancel</see>, OK: <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.OK">OK</see>.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="DetailsMessageBox">DetailsMessageBox</see> is already shown.</exception>
        new public DialogResult Show() => ShowDialog();

        /// <summary>
        /// Shows this instance of DetailsMessageBox with a new owner. This method is equal to <see cref="DetailsMessageBox.ShowDialog(IWin32Window)">ShowDialog</see>.
        /// </summary>
        /// <returns>Clicked button. Close (red X, system menu, ALT+F4, Quit): <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.Cancel">Cancel</see>, OK: <see cref="DialogResult">DialogResult</see>.<see cref="DialogResult.OK">OK</see>.</returns>
        /// <param name="owner">New owner.</param>
        /// <exception cref="InvalidOperationException">Thrown if the <see cref="DetailsMessageBox">DetailsMessageBox</see> is already shown.</exception>
        new public DialogResult Show(IWin32Window owner) => ShowDialog(owner);

        public static void Test(Form parent, Bitmap? image = null)
        {
            Show(parent, "Caption", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi non sagittis tellus,\r\nvel suscipit orci. Nulla et sapien augue. Donec tristique tellus quis turpis maximus.",
                "\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus felis erat, tristique nec ornare at, eleifend non augue. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Praesent et est sed tortor pulvinar eleifend vitae quis diam. Ut ut purus lectus. Mauris sit amet rhoncus erat. Maecenas ornare justo et elit lobortis finibus. Suspendisse potenti. Pellentesque hendrerit diam quis suscipit aliquam. Duis quis nunc pharetra, molestie metus non, suscipit orci. Quisque ultricies eu metus sit amet dignissim. Integer facilisis malesuada leo, quis ornare ante egestas in.\r\n\r\nMauris ut sagittis turpis, suscipit imperdiet est. Aliquam erat volutpat. Donec pharetra lacinia lorem, malesuada iaculis turpis elementum id. Donec tincidunt vel nisi sed sodales. Suspendisse fermentum lectus in nisi bibendum ornare. Maecenas pulvinar augue dui, eu varius enim blandit ut. Nullam scelerisque felis ex, eget posuere orci sodales et. Donec sit amet neque tellus. Integer non tincidunt magna, id ullamcorper eros. Maecenas ut nisl ante. Quisque porttitor volutpat neque id faucibus. Nulla facilisi.\r\n\r\nFusce lobortis nunc accumsan bibendum accumsan. Sed et blandit tortor, vel gravida elit. Nulla ut pretium leo, imperdiet tincidunt lacus. Phasellus sit amet ipsum tempus, ornare dolor vitae, consectetur odio. Nam varius pharetra ex eu congue. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc efficitur ac erat et elementum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ornare blandit risus, a tincidunt lacus. Curabitur auctor augue quis dignissim fringilla. Morbi non ligula et turpis lobortis tempor sed nec quam. Curabitur id semper sapien. Fusce convallis ante in risus euismod finibus. Nullam ultrices ullamcorper purus, ac lobortis risus blandit id. Donec lorem nulla, dictum semper diam vel, vestibulum auctor ipsum. Proin sed nisl lectus.\r\n\r\nCurabitur quis mattis purus. Donec at accumsan lectus. Praesent lacinia ex nunc, id condimentum dolor aliquam ac. Donec nec eros tristique, gravida dui sed, gravida augue. Etiam eu viverra leo. Integer tincidunt et sem a imperdiet. Sed ornare odio ac nisl blandit tempor. Proin at nisi a nisi sodales malesuada.\r\n\r\nNullam tempus libero maximus nisl ultrices, in tristique purus elementum. Vestibulum leo ipsum, interdum in felis in, blandit elementum quam. Morbi tempus elit a cursus porta. Morbi vel eros eget felis accumsan varius. Sed ac iaculis arcu. Nam cursus urna ac arcu blandit feugiat. Duis vel nulla vel sem viverra convallis pellentesque ac massa. Donec orci urna, viverra bibendum cursus vel, tincidunt in nulla. Praesent varius suscipit volutpat. In elementum semper dapibus.",
                image ?? new(1, 1, PixelFormat.Format32bppArgb));
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Caption: {Text}")
                .AppendLine($"Text: {msgText.Text}")
                .AppendLine($"Icon: {icon.ImageLocation}")
                .AppendLine($"Details text: {details}")
                .AppendLine($"Owner: {Owner}")
                .ToString();

        }

        /// <summary>
        /// Fired when the window is expanded.
        /// </summary>
        public event EventHandler? DetailsShown;

        /// <summary>
        /// Fired when the window is shrinked.
        /// </summary>
        public event EventHandler? DetailsHidden;

        /// <summary>
        /// Fired when OK clicked.
        /// </summary>
        public event EventHandler? OKClick;

        /// <summary>
        /// Fired when Quit clicked.
        /// </summary>
        public event EventHandler? QuitClick;


        // PRIVATE
        private static readonly Size initsize = new(448, 215);
        private static readonly Size expandedsize = new(448, 485);

        private void OnDetailsShown() => DetailsShown?.Invoke(this, EventArgs.Empty);
        private void OnOKClick() => OKClick?.Invoke(this, EventArgs.Empty);
        private void OnDetailsHidden() => DetailsHidden?.Invoke(this, EventArgs.Empty);
        private void OnQuitClick() => QuitClick?.Invoke(this, EventArgs.Empty);

        private void toggleDetails_Click(object sender, EventArgs e)
        {
            if (Size == initsize)
            {
                Size = expandedsize;
                toggleDetails.Text = "Hide Details";
                OnDetailsShown();
            }
            else
            {
                Size = initsize;
                toggleDetails.Text = "Show Details";
                OnDetailsHidden();
            }
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            OnQuitClick();
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e) => OnOKClick();

        private void details_LinkClicked(object sender, LinkClickedEventArgs e) => Utility.OpenUrl(e.LinkText);

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(details.Text, TextDataFormat.UnicodeText);
        }
    }
}

/*
 TIP on multilining "msgText" control
 * To set a multiline string to show in the main box, make a verbose string.
 * 
 * EXAMPLE:
 * new DetailsMessageBox(this, "Title", @"This is a line.
 * This is a new line.", "Details", new Bitmap(...))
 * Note: when setting the details box, do the same.
 TIP on expanding the window in VS designer
 * Click on the form.
 * In the Properties window, find Size property.
 * Set its value to 448; 465.
 * After you finish previewing the expanded window, return the Size property back to 448; 215. (IMPORTANT)
*/