public abstract class _41_Script_Handling
{
    protected _1_Boolean__Values test;
    protected _7_Settings set;
    protected _41_Script_Handling(_1_Boolean__Values test, _7_Settings set)
    {
        this.test = test;
        this.set = set;
    }
    private string speaker = "Test :)";
    private string tempspeaker = "Me :)";
    private string line1 = "Test1";
    private string line2 = "Test2";
    private string line3 = "Test3";
    private string line4 = "Test4";
    protected int linenum = 1;
    protected int linesize = 0;
    public string Speaker { get { return speaker; } set { speaker = value; } }
    public string TempSpeaker { get { return tempspeaker; } set { tempspeaker = value; } }
    public string Line1 { get { return line1; } set { line1 = value; } }
    public string Line2 { get { return line2; } set { line2 = value; } }
    public string Line3 { get { return line3; } set { line3 = value; } }
    public string Line4 { get { return line4; } set { line4 = value; } }
    public int LineNum { get { return linenum; } set { linenum = value; } }
    public int LineSize { get { return linesize; } set { linesize = value; } }
    public abstract void ChangeLine();
    public void IncrementLineNum()
    {
        LineNum++;
    }
}
public class _42_Game_Script : _41_Script_Handling
{
    public _42_Game_Script(_1_Boolean__Values test, _7_Settings set) : base(test, set)
    {
        this.test = test;
    }
    public override void ChangeLine()
    {
        switch (linenum)
        {
            case 0:
                Speaker = "Me"; break;
            case 1:
                LineSize = 1;
                Line1 = "[You have just died!]";
                Speaker = "SYSTEM :"; break;
            case 2:
                LineSize = 1;
                Line1 = "“What just happened?”";
                Speaker = "[???] :"; break;
            case 3:
                LineSize = 3;
                Line1 = "“I want to recall something, anything... but my memory";
                Line2 = "fails me of everything I want to know except for";
                Line3 = "what has transpired just now.”";
                Speaker = "[???] :"; break;
            case 4:
                LineSize = 2;
                Line1 = $"[Greetings, S{test.GameID}. We are here to announce again";
                Line2 = $"that you have just died!]";
                Speaker = "SYSTEM :"; break;
            case 5:
                LineSize = 1;
                Line1 = "“I... died?”";
                Speaker = $"S{test.GameID} :"; break;
            case 6:
                LineSize = 3;
                Line1 = "[Indeed so. Your mortal body has received fatal";
                Line2 = "damages to the point you aren't able to recuperate";
                Line3 = "and recover.]";
                Speaker = "SYSTEM :"; break;
            case 7:
                LineSize = 2;
                Line1 = "[You have passed on. Thus, with that said, your soul has";
                Line2 = "completely been separated from your body.]";
                Speaker = "SYSTEM :"; break;
            case 8: //Choose
                LineSize = 1;
                Line1 = "You started feeling...";
                Speaker = $"S{test.GameID} :"; break;
            case 9: //If A
                LineSize = 1;
                Line1 = "“But if I’m dead, wh-what happens to me now...?”";
                Speaker = $"S{test.GameID} :";
                LineNum = 12; break;
            case 10: //If B
                LineSize = 1;
                Line1 = "“Is that so...?”";
                Speaker = $"S{test.GameID} :";
                LineNum = 12; break;
            case 11: //If C
                LineSize = 1;
                Line1 = "“No! That can’t be! I still have many things to do,”";
                Line2 = "and I dropped dead just like that?";
                Speaker = $"S{test.GameID} :";
                LineNum = 12; break;
            case 12: //If D
                LineSize = 1;
                Line1 = "“...”";
                Speaker = $"S{test.GameID} :"; break;
            case 13:
                LineSize = 1;
                Line1 = "[Unfortunately, you lived your last life in vain!]";
                Speaker = "SYSTEM :"; break;
            case 14:
                LineSize = 2;
                Line1 = "[But the higher ups are willing to give you a chance";
                Line2 = "at another shot for life.]";
                Speaker = "SYSTEM :"; break;
            case 15: //Choice
                LineSize = 1;
                Line1 = "[But complying to this will come with a certain cost.]";
                Speaker = "SYSTEM :"; break;
            case 16: //If A
                LineSize = 3;
                Line1 = "[Though I am aware you are unsure of what you are";
                Line2 = "treading, I admire your audacity to inquire. That";
                Line3 = "may mean you are willing to hear us out.]";
                Speaker = "SYSTEM :";
                LineNum = 21; break;
            case 17: //If B
                LineSize = 1;
                Line1 = "[Still not enough time to think?]";
                Speaker = "SYSTEM :";
                LineNum = 21; break;
            case 18: //If C
                LineSize = 3;
                Line1 = "[The fact that you are communicating with me without";
                Line2 = "a body is proof enough. But you can still argue that";
                Line3 = "we could be hallucinating.]";
                Speaker = "SYSTEM :"; break;
            case 19: //If C.2
                LineSize = 3;
                Line1 = "[Either way, I have no qualms on how you’d come to";
                Line2 = "terms in believing what you want to believe.";
                Line3 = "My meager existence here is to deliver instructions.]";
                Speaker = "SYSTEM :";
                LineNum = 21; break;
            case 20: //If D
                LineSize = 1;
                Line1 = "[...]";
                Speaker = "SYSTEM :"; break;
            case 21: //If D.2
                LineSize = 1;
                Line1 = "[As I was saying...]";
                Speaker = "SYSTEM :"; break;
            case 22:
                LineSize = 3;
                Line1 = "[Glitches. Unexplainable happenings. Perceptions of";
                Line2 = "reality that sometimes don't make sense but they";
                Line3 = "seem to be natural occurrences in the world.]";
                Speaker = "SYSTEM :"; break;
            case 23:
                LineSize = 4;
                Line1 = "[Some compensate by calling this an “act of god”.";
                Line2 = "Others refer to this as “hallucinations induced by";
                Line3 = "chemical reactions in the brain.” Such interesting";
                Line4 = "conclusions, you see...]";
                Speaker = "SYSTEM :"; break;
            case 24:
                LineSize = 4;
                Line1 = "[Whether it may be deemed logical ordelusional,";
                Line2 = "humans throughout history come up with answers to";
                Line3 = "such inadequacies to fit their scope of reality,";
                Line4 = "you see.]";
                Speaker = "SYSTEM :"; break;
            case 25: //Choose
                LineSize = 3;
                Line1 = "[Your soul is about to be reincarnated as a child";
                Line2 = "hailing from the harsh winter lands during the 1980's.";
                Line3 = "Will you accept this offer?]";
                Speaker = "SYSTEM :"; break;
            case 26: // If A~
                LineSize = 1;
                Line1 = "[...]";
                Speaker = "SYSTEM :"; break;
            case 27:
                LineSize = 2;
                Line1 = "[This is one of the “bearable” solutions to your";
                Line2 = "soul's redemption.]";
                Speaker = "SYSTEM :"; break;
            case 28:
                LineSize = 3;
                Line1 = "[We cannot fully disclose the rundown as to how our";
                Line2 = "management brings about their decisions since it's";
                Line3 = "a classified matter.]";
                Speaker = "SYSTEM :"; break;
            case 29:
                LineSize = 3;
                Line1 = "[In truth, there are many other ways to achieve";
                Line2 = "redemption, but this route in particular was the";
                Line3 = "one allowed by the management to be taken care of.]";
                Speaker = "SYSTEM :"; break;
            case 30:
                LineSize = 2;
                Line1 = "[Whether it's to accept or refuse the offer, the";
                Line2 = "ultimatum is up to you.]";
                Speaker = "SYSTEM :"; break;
            case 31:
                LineSize = 1;
                Line1 = $"[Please choose wisely, S{test.GameID}.]";
                Speaker = "SYSTEM :"; break;
            case 32:
                LineSize = 4;
                Line1 = "[Again, we will reiterate the briefing about where";
                Line2 = "your soul is about to manifest next: You will be a";
                Line3 = "child hailing from the harsh winter lands during the";
                Line4 = "1980's.]";
                Speaker = "SYSTEM :"; break;
            case 33:
                LineSize = 4;
                Line1 = "[We cannot include further details, but in compliance";
                Line2 = "to the management's policy, you will be forgetting";
                Line3 = "what has transpired here for the sake of legitimacy";
                Line4 = "during the route progression.]";
                Speaker = "SYSTEM :"; break;
            case 34:
                LineSize = 2;
                Line1 = "[Your name will be the sole thing you will remember";
                Line2 = "once you agree to our terms.]";
                Speaker = "SYSTEM :"; break;
            case 35: //Choose && ~A
                LineSize = 1;
                Line1 = "[Will you finally accept this offer?]";
                Speaker = "SYSTEM :"; break;
            case 36: //Yes && Choose
                LineSize = 3;
                Line1 = "[We’re glad we have reached a consensus with this";
                Line2 = "dilemma. Now, if you must, would you like to";
                Line3 = "introduce to us your name?]";
                Speaker = "SYSTEM :"; break;
            case 37: //Choose
                LineSize = 1;
                Line1 = "[What is your preferred nickname?]";
                Speaker = "SYSTEM :"; break;
            case 38: //Choose
                LineSize = 1;
                Line1 = "[How do you like to be perceived as?]";
                Speaker = "SYSTEM :"; break;
            case 39: //Saving file
                LineSize = 2;
                Line1 = "[We are processing your information. Please wait";
                Line2 = "for a moment...]";
                Speaker = "SYSTEM :"; break;
            case 40:
                LineSize = 1;
                Line1 = "[Personal information officially registered.]";
                Speaker = "SYSTEM :"; break;
            case 41: //Introduction end
                LineSize = 3;
                Line1 = "[Thank you for your trust and cooperation with us.";
                Line2 = "We appreciate your earnestness, and we hope you";
                Line3 = "are able to lead a new life ahead!]";
                Speaker = "SYSTEM :";
                break;
            case 42: //Hidden Ending 1
                LineSize = 1;
                Line1 = $"[Well, then. Farewell to thee, S{test.GameID}.]";
                Speaker = "SYSTEM :"; break;
            case 43: //End~
                LineSize = 3;
                Line1 = "Your soul was sent to the void, never to set foot";
                Line2 = "and resurface into the mortal realm until the end";
                Line3 = "of time.";
                Speaker = "...:"; break;
            case 44: //Act 01
                LineSize = 3;
                Line1 = "The seemingly condensed apartments were clustered";
                Line2 = "in the midst of Yekaterinburg’s cityscape, brimming";
                Line3 = "like the vodka dripping from the local’s mugs.";
                Speaker = "..."; break;
            case 45:
                LineSize = 4;
                Line1 = "Excluding the one owned by a certain man named";
                Line2 = "Pavlov Vladimich Morosov and his family,";
                Line3 = "every establishment was bestowed by the blessing";
                Line4 = "of peace and solemnity.";
                Speaker = "..."; break;
            case 46:
                LineSize = 4;
                Line1 = "Excluding the one owned by a certain man named";
                Line2 = "Pavlov Vladimich Morosov and his family,";
                Line3 = "every establishment was bestowed by the blessing";
                Line4 = "of peace and solemnity.";
                Speaker = "..."; break;
            case 47:
                LineSize = 4;
                Line1 = "When the fingers of the dawning sun began to";
                Line2 = "stretch forth across the heart of the city, the";
                Line3 = "radiance would bask the area with ethereal and";
                Line4 = "inexplicable warmth despite the brutal downfall";
                Speaker = "..."; break;
            case 48:
                LineSize = 1;
                Line1 = "of hail and snow.";
                Speaker = "..."; break;
            case 49:
                LineSize = 4;
                Line1 = "The light dwelt upon the land, revealing the stark";
                Line2 = "contrast of the dull scenes in the city-the stoic";
                Line3 = "faces of the humans, the washed-out quality of the";
                Line4 = "infrastructures, and the small footprints";
                Speaker = "..."; break;
            case 50:
                LineSize = 2;
                Line1 = $"of a child returning to a house {test.Pronoun1_1} never";
                Line2 = "considered a home.";
                Speaker = "..."; break;
            case 51:
                LineSize = 4;
                Line1 = "Winter was cruel and cold and so was Pavlov, a man ";
                Line2 = "who might rebuke his child upon stepping foot on his";
                Line3 = $"threshold. The said child-{test.FirstName} Pavlovich";
                Line4 = "Morosov-stepped right at their apartment entrance,";
                Speaker = "..."; break;
            case 52:
                LineSize = 2;
                Line1 = $"{test.Pronoun2_1} shivering hand lightly rested atop the brass";
                Line2 = "doorknob.";
                Speaker = "..."; break;
            case 53:
                LineSize = 1;
                Line1 = $"“{test.NickName}!”";
                Speaker = "??? :"; break;
            case 54:
                LineSize = 4;
                Line1 = "A small, shrill voice rang out from the inside of";
                Line2 = "the apartment. The door creaked open, giving way to";
                Line3 = $"a petite girl who was much younger than {test.FirstName}";
                Line4 = $"{test.Pronoun4_1}.";
                Speaker = "..."; break;
            case 55:
                LineSize = 1;
                Line1 = "“Papa bought us a dining table!”";
                Speaker = "???"; break;
            case 56:
                LineSize = 3;
                Line1 = $"Dining table? {test.FirstName} thought to himself miserably.";
                Line2 = "He couldn’t afford a decent meal, yet he can avail";
                Line3 = "the damn furniture?";
                Speaker = "..."; break;
            case 57:
                LineSize = 1;
                Line1 = "“What dining table, Lyudmila?”";
                Speaker = $"{test.FirstName} :"; break;
            case 58:
                LineSize = 1;
                Line1 = "“The type that’s round and colorful and wordy!”";
                Speaker = "Lyudmila :"; break;
            case 59:
                LineSize = 3;
                Line1 = $"{test.Pronoun2} four-year-old sister beamed a smile, though";
                Line2 = $"{test.FirstName} noticed the faint quivering of her voice";
                Line3 = "opposing her cheerful demeanor.";
                Speaker = "..."; break;
            case 60:
                LineSize = 1;
                Line1 = $"“And you know what’s the best part, {test.NickName}?”";
                Speaker = "Lyudmila :"; break;
            case 61:
                LineSize = 1;
                Line1 = "“It actually spins!”";
                Speaker = "Lyudmila :"; break;
            case 62:
                LineSize = 1;
                Line1 = "“Really? Is that so...”";
                Speaker = $"{test.FirstName} :"; break;
            case 63:
                LineSize = 2;
                Line1 = $"“What’s with the long face, {test.NickName}? Come, I’ll”";
                Line2 = "show you! Cobrat and the rest are waiting.";
                Speaker = "Lyudmila :"; break;
            case 64:
                LineSize = 4;
                Line1 = "As the two siblings headed towards the dining table,";
                Line2 = $"side to side, {test.FirstName} immediately spotted the newly";
                Line3 = "purchased table, though it wasn’t what it seemed";
                Line4 = "to be.";
                Speaker = "..."; break;
            case 65:
                LineSize = 4;
                Line1 = "It appeared to be a typical round table, but one";
                Line2 = $"thing {test.FirstName} couldn’t take {test.Pronoun2_1} eyes off were";
                Line3 = "the lines of colors, darting and splaying in";
                Line4 = "several shades and slots across the circular";
                Speaker = "..."; break;
            case 66:
                LineSize = 1;
                Line1 = "spinning board.";
                Speaker = "..."; break;
            case 67:
                LineSize = 4;
                Line1 = "Embedded on the board were the words patched in a";
                Line2 = "hybrid of Cyrillic and English, the letters morphing";
                Line3 = "into instructions so vague and incredulous to either";
                Line4 = "comprehend or compensate.";
                Speaker = "..."; break;
            case 68:
                LineSize = 4;
                Line1 = "Despite the delectable aroma of borscht and";
                Line2 = "goblutsky wafting in the air and the perfect";
                Line3 = $"arrangement of the viands and delicacies, {test.FirstName}’s";
                Line4 = "stomach dropped heavily and churned nervously.";
                Speaker = "..."; break;
            case 69:
                LineSize = 4;
                Line1 = $"The idea of {test.Pronoun3_1} enjoying breakfast with {test.Pronoun2_1}";
                Line2 = "family on that particular thing was simply mad,";
                Line3 = "especially when the very surface of the table";
                Line4 = "itself was modeled after the deadliest among gambles";
                Speaker = "..."; break;
            case 70:
                LineSize = 1;
                Line1 = "and games the Russian roulette.";
                Speaker = "..."; break;
            case 71:
                LineSize = 1;
                Line1 = $"“{test.FirstName}. Sit.”";
                Speaker = "Pavlov :"; break;
            case 72:
                LineSize = 3;
                Line1 = $"{test.Pronoun2} father commanded from his seat. Pavlov never";
                Line2 = "called his children by their diminutives, lest he";
                Line3 = "would be intimate with them.";
                Speaker = "..."; break;
            case 73:
                LineSize = 3;
                Line1 = "“You’re late. We have Lyudmila’s ballet recital to”";
                Line2 = "attend at one in the afternoon, and you’re still in";
                Line3 = "your tracking clothes.";
                Speaker = "Pavlov :"; break;
            case 74:
                LineSize = 3;
                Line1 = $"Without a word, {test.FirstName} gritted {test.Pronoun2_1} teeth as";
                Line2 = $"{test.Pronoun1_1} sat on {test.Pronoun2_1} chair, muttering curses {test.Pronoun1_1}";
                Line3 = $"could think of inside {test.Pronoun2_1} head.";
                Speaker = "..."; break;
            case 75:
                LineSize = 4;
                Line1 = $"{test.Pronoun2} father’s archaic and straightforward manner";
                Line2 = $"of speaking irked {test.Pronoun3_1} quite a lot recently,";
                Line3 = $"though {test.Pronoun1_1} wouldn’t dare voice out {test.Pronoun2_1} discomfort.";
                Line4 = "infrastructures, and the small footprints";
                Speaker = "..."; break;
            case 76:
                LineSize = 2;
                Line1 = $"{test.Pronoun1} knew what would happen if {test.Pronoun1_1} would unleash";
                Line2 = $"the beast within {test.Pronoun2_1} father.";
                Speaker = "..."; break;
            case 77:
                LineSize = 2;
                Line1 = $"Little did our {test.FirstName} know Pavlov was already";
                Line2 = "a beast.";
                Speaker = "..."; break;
            case 78:
                LineSize = 2;
                Line1 = "For the first few minutes, not a single soul tried";
                Line2 = "to scoop some food on their plates.";
                Speaker = "..."; break;
            case 79: //Choose between A, B, C
                LineSize = 1;
                Line1 = $"What will {test.FirstName} do?";
                Speaker = "..."; break;
            case 80: //Act 2.0
                LineSize = 3;
                Line1 = $"Then, {test.FirstName}’s stomach-growling urged Sergei to";
                Line2 = "twist the board, for that was where their meal was";
                Line3 = "placed.";
                Speaker = "..."; break;
            case 81:
                LineSize = 4;
                Line1 = $"When {test.FirstName}’s older brother reached the ladle to";
                Line2 = "ease himself with their mother’s homemade borscht,";
                Line3 = "his father held out a calloused hand to stop him";
                Line4 = "from doing so.";
                Speaker = "..."; break;
            case 82:
                LineSize = 1;
                Line1 = "“What?”";
                Speaker = "Sergei :"; break;
            case 83:
                LineSize = 1;
                Line1 = "Sergei groaned.";
                Speaker = "..."; break;
            case 84:
                LineSize = 1;
                Line1 = "“I’m starving, for Christ’s sake, papa!”";
                Speaker = "Sergei :"; break;
            case 85:
                LineSize = 2;
                Line1 = "Pavlov’s emerald-gray eyes gleamed of dangerous";
                Line2 = "light, cold yet calculating.";
                Speaker = "..."; break;
            case 86:
                LineSize = 3;
                Line1 = "Their father pointed to the row of words embossed";
                Line2 = "beneath the bowl of borscht. It was inscribed in";
                Line3 = "Cyrillic, but in English, it read as:";
                Speaker = "..."; break;
            case 87:
                LineSize = 1;
                Line1 = "TAKE THE FOOD AND THROW IT AWAY.";
                Speaker = "Note :"; break;
            case 88:
                LineSize = 3;
                Line1 = "Sergei’s expression was rather stunned, his eyes";
                Line2 = "widening in pure shock and his mouth agape of";
                Line3 = "speechlessness.";
                Speaker = "..."; break;
            case 89:
                LineSize = 1;
                Line1 = "“Papa, I can’t do this!”";
                Speaker = "Sergei :"; break;
            case 90:
                LineSize = 4;
                Line1 = "Sergei retorted at this, his voice rising higher";
                Line2 = "as his anger elevated like a subterranean volcano";
                Line3 = "breaching the ocean’s surface with violent plumes";
                Line4 = "of smoke and ash.";
                Speaker = "..."; break;
            case 91:
                LineSize = 2;
                Line1 = "“This is stupidity at its finest! So, you’re telling";
                Line2 = "me to get what you bought just to throw it away?”";
                Speaker = "Sergei :"; break;
            case 92:
                LineSize = 2;
                Line1 = "“Really? Are you still the father that I used to";
                Line2 = "respect?”";
                Speaker = "..."; break;
            case 93:
                LineSize = 2;
                Line1 = "Surprised by Sergei’s rebellious nature, Pavlov";
                Line2 = "kept his face at its usual form-stern and hard.";
                Speaker = "..."; break;
            case 94:
                LineSize = 4;
                Line1 = "He fished out a certain something which turned out";
                Line2 = "to be nothing from the waistband of his pants, held";
                Line3 = "out his hand as if he were holding a weapon and shot";
                Line4 = "Sergei squarely at the chest.";
                Speaker = "..."; break;
            case 95:
                LineSize = 3;
                Line1 = $"{test.FirstName} shrunk back to his chair in horror as he";
                Line2 = "witnessed his brother’s lifeless body drop to the";
                Line3 = "floor.";
                Speaker = "..."; break;
            case 96:
                LineSize = 3;
                Line1 = "Among Lyudmila’s screaming and Lilia’s heaving,";
                Line2 = $"{test.FirstName}’s conscience dismembering {test.Pronoun2_1} insides was";
                Line3 = $"the greatest reaction {test.Pronoun1_1} could offer.";
                Speaker = "..."; break;
            case 97:
                LineSize = 3;
                Line1 = $"The middle child couldn’t comprehend how {test.Pronoun2_1} papa";
                Line2 = "could commit a murder without physical evidence of";
                Line3 = "a weapon other than the aftermath itself.";
                Speaker = "..."; break;
            case 98:
                LineSize = 4;
                Line1 = $"{test.Pronoun1} could see it, but then {test.Pronoun1_1} couldn’t. A physical";
                Line2 = "manifestation of a paradox, if you could call the";
                Line3 = $"existence of an invisible caliber physical. {test.Pronoun2}";
                Line4 = "brain was mushed far enough to relieve such a";
                Speaker = "..."; break;
            case 99:
                LineSize = 1;
                Line1 = "ghastly scene.";
                Speaker = "..."; break;
            case 100:
                LineSize = 4;
                Line1 = "Amidst the contemplation of three troubled minds,";
                Line2 = "Pavlov opened the cartridge of his revolver to";
                Line3 = "fill one-sixth of the cylinder slots with a sole";
                Line4 = "bullet before spinning it round.";
                Speaker = "..."; break;
            case 101:
                LineSize = 4;
                Line1 = "Securing the barrel shut, he cocked the hammer in";
                Line2 = "advance, ready to execute an instant pull of a";
                Line3 = "trigger just in case one of his family would detest";
                Line4 = "the roulette’s heeds.";
                Speaker = "..."; break;
            case 102:
                LineSize = 4;
                Line1 = "He gave each of the three a benefit of a cold,";
                Line2 = "lethal gaze before setting the revolver beside his";
                Line3 = "ceramic bowl and helping himself to a spoonful of";
                Line4 = "the sour soup that was supposed to be Sergei’s share.";
                Speaker = "..."; break;
            case 103:
                LineSize = 3;
                Line1 = $"“Papa shot his own son!” {test.FirstName}’s thoughts were";
                Line2 = $"now at the point of puncturing {test.Pronoun2_1} skullcaps.";
                Line3 = "“Will he shoot us too if we do the actions otherwise?”";
                Speaker = "..."; break;
            case 104:
                LineSize = 2;
                Line1 = $"With a trembling hand, {test.FirstName} opted for the pirozhki,";
                Line2 = "spinning the board counter-clockwise.";
                Speaker = "..."; break;
            case 105:
                LineSize = 4;
                Line1 = $"When the plate was favorable to reach, {test.Pronoun1_1} paused,";
                Line2 = $"closing {test.Pronoun2_1} eyes for a few moments to gather {test.Pronoun2_1}";
                Line3 = "sanity together, and bowed down at what the colorful";
                Line4 = $"slot had in store for {test.Pronoun3_1}.";
                Speaker = "..."; break;
            case 106:
                LineSize = 4;
                Line1 = $"As much as {test.Pronoun1_1} felt woeful for Sergei and his imminent";
                Line2 = $"death, {test.FirstName} couldn’t help but think of surviving,";
                Line3 = $"preferably not dying on the hands of {test.Pronoun2_1} tyrannical";
                Line4 = "father. It would be the worst of chances fate was";
                Speaker = "..."; break;
            case 107:
                LineSize = 1;
                Line1 = $"going to give to {test.Pronoun3_1}.";
                Speaker = "..."; break;
            case 108:
                LineSize = 2;
                Line1 = $"Was {test.Pronoun1_1} going to be spared or was {test.Pronoun1_1} going to {test.Pronoun2_1}";
                Line2 = "demise?";
                Speaker = "..."; break;
            case 109:
                LineSize = 2;
                Line1 = $"Opening {test.Pronoun2_1} eyes, {test.FirstName} was welcomed with three";
                Line2 = "words:";
                Speaker = "..."; break;
            case 110:
                LineSize = 1;
                Line1 = "KILL YOUR FATHER.";
                Speaker = "..."; break;
            case 111: //end of the latest update
                LineSize = 4;
                Line1 = $"{test.FirstName} didn’t hesitate to take the invisible gun";
                Line2 = $"and shoot {test.Pronoun2_1} father right at the head. They didn’t";
                Line3 = "like him anyway.";
                Speaker = "..."; break;
        }
        IncrementLineNum();
    }
}
