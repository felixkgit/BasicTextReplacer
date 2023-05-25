using System.Text.RegularExpressions;

namespace BasicTextReplacer {
    public partial class MainForm : Form {
        private static string text = "";
        private static string pattern = @"\[(.*?)\]";

        private static List<string> matchList = new();
        private static Dictionary<string, string> replacements = new();

        public MainForm() => InitializeComponent();

        /// <summary>
        /// Handles the logic for loading a file and creating the required controls
        /// </summary>
        private void LoadFileButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Text Files|*.txt";
                ofd.Title = "Select a Text File...";

                //  Ensure file was opened successfully
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                /// 1. Clear the lists
                InitalizeReplacements();

                //  Only ever write to `text` here, when initalizing
                text = File.ReadAllText(ofd.FileName);
                /// 2. Show the text
                PreviewText(text);

                /// 3. Parse the replacements
                MatchCollection matches = Regex.Matches(text, pattern);

                /// 4. Create the `replacements`
                int i = -2;
                foreach (Match match in matches)
                    if (!matchList.Contains(match.Value))
                        CreateReplacement(match.Value, i += 2);
            }
        }

        /// <summary>
        /// Copies the preview text to the clipboard
        /// </summary>
        private void ExportClipboardButton_Click(object sender, EventArgs e) {
            //  Ensure there's text to copy
            if (string.IsNullOrEmpty(PreviewTextBox.Text))
                return;

            //  Add text to clipboard
            Clipboard.SetText(PreviewTextBox.Text);
        }

        /// <summary>
        /// Clears/Resets the lists used by the application
        /// </summary>
        private void InitalizeReplacements() {
            matchList.Clear();
            replacements.Clear();
            ReplacementsPanel.Controls.Clear();
        }

        /// <summary>
        /// Sets the preview text
        /// </summary>
        /// <param name="text">The text to set the preview to</param>
        private void PreviewText(string text) {
            PreviewTextBox.Text = text;
        }

        /// <summary>
        /// Creates UI components for the replacement
        /// </summary>
        /// <param name="text">The text of the replacement (that is to be replaced)</param>
        /// <param name="index">The veritcal index, used to position the components</param>
        private void CreateReplacement(string text, int index) {
            //  Initalize components for replacement
            Label label = new Label() { Text = text, Width = 200, Location = new(10, index * 30 + 5) };
            TextBox textbox = new TextBox() { Name = text, Width = 200, Location = new(10, index * 30 + 30) };
            textbox.TextChanged += UpdateText;

            //  Add components for replacement
            ReplacementsPanel.Controls.Add(label);
            ReplacementsPanel.Controls.Add(textbox);

            //  Add to list
            matchList.Add(text);
        }

        /// <summary>
        /// Updates the text in the preview window. Also adds the text to the dictionary,
        /// if not already added to the replacements.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateText(object? sender, EventArgs e) {
            if (sender is not TextBox || sender == null)
                return;
            TextBox s = (TextBox)sender;

            /// 1. Add to queue if not exists, otherwise update
            if (!replacements.ContainsKey(s.Name))
                replacements.Add(s.Name, s.Text);
            else
                replacements[s.Name] = s.Text;

            /// 2. Run through queue
            //  Get old text
            string newText = text;

            //  Replace the text iteratively
            for (int i = 0; i < matchList.Count; i++) {
                //  Skip if the replacement doesn't exist yet (nothing has been typed in)
                if (!replacements.ContainsKey(matchList[i]) || string.IsNullOrEmpty(replacements[matchList[i]]))
                    continue;

                //  Set the text
                newText = newText.Replace(matchList[i], replacements[matchList[i]]);
            }

            //  Update preview text with replaced text
            PreviewText(newText);
        }
    }
}