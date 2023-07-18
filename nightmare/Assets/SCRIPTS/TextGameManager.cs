using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro,HPTextMeshPro,STAMINATextMeshPro,titleTextMeshPro;
    public string storyText;
    public int hpValue;
    public int staminaValue;
    public string gameTitle;
    public GameObject startMenu;
    public GameObject level1_choices, level2_choices, 
        ui, story, startButton, titleText, tryToWakeUp, 
        continueMoving, talkToTheMonster, tryAgain, explorefurther, 
        findAWayOut, level3_choices, proceed, level4_choices, level3b_choices, level4b_choices, goInsideThePortal, level4c_choices, level5_choices, next;

    // Start is called before the first frame update
    void Start()
    {
        
        ui.SetActive(false);
        level1_choices.SetActive(false);
        story.SetActive(false);
        continueMoving.SetActive(false);
        talkToTheMonster.SetActive(false);
        level2_choices.SetActive(false);
        tryAgain.SetActive(false);
        tryToWakeUp.SetActive(false);
        level3_choices.SetActive(false);
        proceed.SetActive(false);
        level4_choices.SetActive(false);
        level3b_choices.SetActive(false);
        level4b_choices.SetActive(false);
        goInsideThePortal.SetActive(false);
        level4c_choices.SetActive(false);
        level5_choices.SetActive(false);
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        titleTextMeshPro.text = gameTitle;
        storyTextMeshPro.text = storyText;
        HPTextMeshPro.text = hpValue.ToString();
        STAMINATextMeshPro.text = staminaValue.ToString();
        
        
    }
    public void start()
    {
        ui.SetActive(true); 
        story.SetActive(true);
        startButton.SetActive(false);
        level1_choices.SetActive(true);
        hpValue = 10;
        staminaValue = 10;
        titleText.SetActive(false);
        level2_choices.SetActive(false);
        tryToWakeUp.SetActive(true);
        




    }
        
    public void TryToWakeUp()
    {
        storyText = "Your head started to hurt, it's no use";
        tryToWakeUp.SetActive(false);
        hpValue--;
        
    }
    public void ExploreSurroundings()
    {
        storyText = "You died";
        hpValue = 0;
        staminaValue= 0;    
        tryAgain.SetActive(true);
        level1_choices.SetActive(false);
    }

    public void FindASafePlace()
    {
        storyText = "You avoided the horde of monsters passing through";
        staminaValue--;
        level1_choices.SetActive(false);
        tryToWakeUp.SetActive(false);
        continueMoving.SetActive(true);
    }

    public void TryAgain()
    {
        ui.SetActive(true);
        story.SetActive(true);
        startButton.SetActive(false);
        level1_choices.SetActive(true);
        hpValue = 10;
        staminaValue = 10;
        titleText.SetActive(false);
        level2_choices.SetActive(false);
        tryAgain.SetActive(false);


        tryToWakeUp.SetActive(true);
        storyText = "You're having a nightmare but something's wrong, everything feels so real and then you realize.... you are stuck in your own nightmare.";
    }

    public void ContinueMoving()
    {
        storyText = "You proceed to explore the place. You can't help but notice a disabled monster at the alleyway. It looks harmless.";
        talkToTheMonster.SetActive(true);
    }
    
    public void TalkToTheMonster()
    {
        storyText = "You find out that the monsters know that you are conscious and this gives them an opportunity to kill you";
        talkToTheMonster.SetActive(false);
        level2_choices.SetActive(true);
        continueMoving.SetActive(false);

    }



    //EXPLORE FUTHER BRANCH
    public void ExploreFurther()
    {
        storyText = "You see a big castle-like building. That building might be the key to all of this.";
        level2_choices.SetActive(false);
        level3_choices.SetActive(true);
    }

    public void GoBack()
    {
        level3_choices.SetActive(false);
        storyText = "The monsters were already following you and killed you";
        tryAgain.SetActive(true);
        hpValue= 0;
        staminaValue= 0;
    }

    public void GoInside()
    {
        level3_choices.SetActive(false);
        storyText = "Your head started to hurt and you fall to the floor. Visions starts to appear in your head and you realized that this place is giving you information about the truth of this whole place. " +
            "As few minutes pass by, you start to stabilize. You then stand up.... you now know that this place is another dimension which can only be accessed when a person is in their dreaming state. With all" +
            " the knowledge that you just received, you are given an opportunity to rule this place.";

        level4_choices.SetActive(true);
        
    }

    
    //ENDING 7
    public void King()
    {
        level4_choices.SetActive(false);
        storyText = "You used your newly-acquired knowledge and the monsters started to worship you.\n\n\n\nENDING # 7";
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }

    //ENDING 6
    public void BackToRealWorld()
    {
        level4_choices.SetActive(false);
        storyText = "You woke up sweaty and scared. Your heart keeps beating faster and faster but slows down as your memory of that dream fades away.\n\n\n\nENDING #6";
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }
    
    //FIND A WAY OUT BRANCH

    public void FindAWayOut()
    {
        level2_choices.SetActive(false);
        storyText = "The disabled monster offered to help";
        level3b_choices.SetActive(true);

    }


    //Decline offer Branch
    public void declineHisOffer()
    {
        level3b_choices.SetActive(false);
        storyText = "The monster gets angry and morphed into a bigger monster";
        level4b_choices.SetActive(true);

    }


    //Flee branch / ENDING #2
    public void flee()
    {
        level4b_choices.SetActive(false);
        storyText = "The monster was too fast and it was able to keep up with you. " +
            "It used its tentacles to take your heart. " +
            "You started to faint as you see " +
            "visions of your real body being taken over by the monster.\n\n ENDING #2";
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }

    // Fight the monster branch

    public void fightTheMonster()
    {
        storyText = "You were able to defeat the monster. A few seconds later, it's body started to light up and opened a portal";
        level4b_choices.SetActive(false);
        goInsideThePortal.SetActive(true);

    }

    // ENDING # 1
    public void enterThePortal()
    {
        storyText = "You woke up sweaty and scared. Your heart keeps beating faster and faster but slows down as your memory of that dream fades away.\n\n ENDING #1";
        goInsideThePortal.SetActive(false);
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }

    //Accept offer branch
    public void acceptHisOffer()
    {
        level3b_choices.SetActive(false);
        storyText = "He leads you to a weird looking door and proves that the door leads back to your original body. " +
            "This convinces you that this door isn't a trap but something still doesn't feel right.";
        level4c_choices.SetActive(true);
    }

    //Go inside branch / ENDING #3
    public void goInside()
    {
        storyText = " As you're about to enter, the monster grabs your shoulder and stabs you at the chest. " +
            "You started to faint as it replaces it's heart with your heart and then going inside the door. " +
            "You are now dying while it takes over your real body, being the new you.\n\n ENDING #3";
        level4c_choices.SetActive(false);
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }

    //Stay branch

    public void stay()
    {
        storyText = "You lean back and catches the monster readying its tentacles to stab you. " +
            "You immediately roll over to dodge the tentacles. " +
            "You are now a few feet away from the door.";
        level4c_choices.SetActive(false);
        level5_choices.SetActive(true);
    }

    //Go inside door branch // ENDING #4

    public void goInsideTheDoor()
    {
        storyText = "It's long tentacles stabs you and pulls you back. It then takes your heart as you are lying down dying on the floor. " +
            "It replaces it's heart with yours and proceeds to walk inside door. It now takes over your real body, being the new you.\n\n ENDING #4";
        level5_choices.SetActive(false);
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }

    //Fight branch

    public void fight()
    {
        storyText = "You were able to counter it's fast tentacles with your fast reaction time. " +
            "You have now killed the monster with all your strength and proceeds to walk to the door.";
        level5_choices.SetActive(false);
        next.SetActive(true);

    }

    public void Next()
    {
        storyText = "You woke up sweaty and scared. " +
            "Your heart keeps beating faster and faster but slows down as your memory of that dream fades away.\n\n ENDING #5";
        next.SetActive(false);
        ui.SetActive(false);
        tryAgain.SetActive(true);
    }
   
    




















    
}
