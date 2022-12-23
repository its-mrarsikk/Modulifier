using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Modulifier
{
    /// <summary>
    /// Message box with the ability to expand and show details.
    /// </summary>
    public partial class DetailsMessageBox : Form
    {
        /// <summary>
        /// Creates an instance of DetailsMessageBox with the specified owner and contents.
        /// </summary>
        /// <param name="owner">Owner of this window.</param>
        /// <param name="caption">Title of the window.</param>
        /// <param name="text">Text, shown in the main box.</param>
        /// <param name="details">Text, shown in the details box.</param>
        /// <param name="icon">Icon, shown in the main box.</param>
        public DetailsMessageBox(IWin32Window owner, string caption, string text, string details, Bitmap icon)
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
        public event EventHandler DetailsShown;

        /// <summary>
        /// Fired when the window is shrinked.
        /// </summary>
        public event EventHandler DetailsHidden;

        /// <summary>
        /// Fired when OK clicked.
        /// </summary>
        public event EventHandler OKClick;

        /// <summary>
        /// Fired when Quit clicked.
        /// </summary>
        public event EventHandler QuitClick;


        // PRIVATE
        private static readonly Size initsize = new(448, 250);
        private static readonly Size expandedsize = new(448, 500);

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
 * Set its value to 448; 500.
 * After you finish previewing the expanded window, return the Size property back to 448; 250. (IMPORTANT)
*/