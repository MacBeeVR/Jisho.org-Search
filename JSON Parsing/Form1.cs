using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace JSON_Parsing
{
    public partial class searchWindow : Form
    {
        private WordList.RootObject words;
        private string previousSearchTerm;

        public searchWindow()
        {
            InitializeComponent();
        }

        //On Window Load
        private void searchWindow_Load(object sender, EventArgs e)
        {
            //Setting the DisplayMembers to the corresponding properties.
            wordListBox.DisplayMember = "display";
            wordTypeComboBox.DisplayMember = "combinedPartsOfSpeech";
            otherFormsBox.DisplayMember = "word";

            
            previousSearchTerm = "";
            
            otherFormsBox.Enabled = false;
            wordTypeComboBox.Enabled = false;
        }
        

        //Search Button Handler
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Checking for empty string or previously entered string before searching Jisho to prevent unnecessary downloads.
            if (!japaneseWord.Text.Equals("") & !japaneseWord.Text.Equals(previousSearchTerm))
            {
                previousSearchTerm = japaneseWord.Text;

                if(wordListBox.Items.Count > 0)
                    wordListBox.Items.Clear();
                
                //Downloading JSON String from Jisho and parsing into the words WordList class using JsonConvert from JSON.Net
                words = new WordList.RootObject();
                string json = new WebClient() { Encoding = Encoding.UTF8 }.DownloadString("http://jisho.org/api/v1/search/words?keyword=" + japaneseWord.Text);
                words = JsonConvert.DeserializeObject<WordList.RootObject>(json);
                
                //Setting the word property as the reading property if no word property was found.
                for(int i = 0; i < words.data.Count; i++)
                {
                    if (words.data[i].japanese[0].word == null)
                        words.data[i].japanese[0].word = words.data[i].japanese[0].reading;

                    wordListBox.Items.Add(words.data[i]);
                }
            }
        }


        //Handler for Word List listbox
        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Making sure an item has been selected first.
            if (wordListBox.SelectedIndex != -1)
            {
                if (wordTypeComboBox.Items.Count > 0)
                    wordTypeComboBox.Items.Clear();
                if (otherFormsBox.Items.Count > 0)
                    otherFormsBox.Items.Clear();

                for (int i = 0; i < words.data[wordListBox.SelectedIndex].senses.Count; i++)
                {
                    //Checks if there is already a Combined Part of Speech string for the object.
                    //If not, it will combine the parts_of_speech strings but if there is still nothing there, assign "other" since none were given by jisho.
                    if (words.data[wordListBox.SelectedIndex].senses[i].combinedPartsOfSpeech == null)
                        words.data[wordListBox.SelectedIndex].senses[i].setCombinedPOS();
                    if (words.data[wordListBox.SelectedIndex].senses[i].combinedPartsOfSpeech == null)
                        words.data[wordListBox.SelectedIndex].senses[i].combinedPartsOfSpeech = "Other";

                    wordTypeComboBox.Items.Add(words.data[wordListBox.SelectedIndex].senses[i]);
                }

                //if there is no word in the "word" property then set the "word" property to the same value as the "reading" property.
                for (int i = 0; i < words.data[wordListBox.SelectedIndex].japanese.Count; i++)
                {
                    if (words.data[wordListBox.SelectedIndex].japanese[i].word == null)
                        words.data[wordListBox.SelectedIndex].japanese[i].word = words.data[wordListBox.SelectedIndex].japanese[i].reading;
                    otherFormsBox.Items.Add(words.data[wordListBox.SelectedIndex].japanese[i]);
                }

                //If there are any options to choose, enable the corresponding combo box.
                if (otherFormsBox.Items.Count > 1)
                    otherFormsBox.Enabled = true;
                else
                    otherFormsBox.Enabled = false;
                if (wordTypeComboBox.Items.Count > 1)
                    wordTypeComboBox.Enabled = true;
                else
                    wordTypeComboBox.Enabled = false;

                //Creates combined tag string, checks if null, if so then no tag provided, otherwise display the tags.
                if (words.data[wordListBox.SelectedIndex].combinedTags == null)
                    words.data[wordListBox.SelectedIndex].setCombinedTags();
                if (words.data[wordListBox.SelectedIndex].combinedTags == null)
                    tags.Text = "No Tags Provided";
                else
                    tags.Text = words.data[wordListBox.SelectedIndex].combinedTags;

                //Defaulting the selected index for the boxes to the first option.
                otherFormsBox.SelectedIndex = 0;
                wordTypeComboBox.SelectedIndex = 0;
            }  
        }

        //Handler for the Word Type combobox
        private void wordTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(wordTypeComboBox.SelectedIndex != -1)
            {
                //Resetting the text to be empty so the previous text isn't still displayed when going through the next loop.
                definition.Text = "";

                //Number of definitons
                int defCount = words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].english_definitions.Count;

                //Loop for showing all of the definitions within the current word type.
                for (int i = 0; i < defCount; i++)
                {
                    string currentDef = words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].english_definitions[i];

                    if (i != defCount - 1)
                        definition.Text += (i + 1) + ". " + currentDef +"\n";
                    else
                        definition.Text += (i + 1) + ". " + words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].english_definitions[i];
                }

                //Creates combined subtag string, checks if null, if so then no tag is progived, otherwise display the tags.
                if (words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].combinedTags == null)
                    words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].setCombinedTags();
                if (words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].combinedTags == null)
                    subtag.Text = "No Subtags Provided";
                else
                    subtag.Text = words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].combinedTags;

                //Creates combined info string, checks if null, if so then no info, otherwise display info.
                if (words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].combinedInfo == null)
                    words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].setCombinedInfo();
                if (words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].combinedInfo == null)
                    info.Text = "No Info Provided";
                else
                    info.Text = words.data[wordListBox.SelectedIndex].senses[wordTypeComboBox.SelectedIndex].combinedInfo;
            }
        }

        //Handler for box other forms box which holds other usages/spellings of the selected word.
        private void otherFormsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (otherFormsBox.SelectedIndex != -1)
            {
                word.Text = words.data[wordListBox.SelectedIndex].japanese[otherFormsBox.SelectedIndex].word;
                reading.Text = words.data[wordListBox.SelectedIndex].japanese[otherFormsBox.SelectedIndex].reading;
            }
        }
    }
}
