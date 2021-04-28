$(".stat").bind("input", function() {
  var inputName = $(this).attr("name");
  var cleanmod = parseInt($(this).val()) - 10;

  if (cleanmod % 2 == 0) cleanmod = cleanmod / 2;
  else cleanmod = (cleanmod - 1) / 2;

  var mod = cleanmod;

  if (isNaN(cleanmod)) mod = "";
  else if (mod >= 0) mod = "+" + mod;

  var scoreName = inputName.slice(0, inputName.indexOf("score"));
  var modName = scoreName + "mod";

  var saveName = scoreName + "_save";

  var skillName = scoreName + "_skill";

  var saveProfName = scoreName + "_save_prof";

  $("[name='" + modName + "']").val(mod);

  $("[name='" + saveName + "']").val(mod);

  if (scoreName == "Strength")
    {
      $("[name='Athletics_skill']").val(mod);
    }

  if (scoreName == "Dexterity") {
    $("     [name='initiative']").val(mod);
    
    $("[name='Acrobatics_skill']").val(mod);
    $("[name='SleightofHand_skill']").val(mod);
    $("[name='Stealth_skill']").val(mod);
  }

  if (scoreName == "Wisdom") {
    var passive = 10 + cleanmod;

    $("   [name='passiveperception']").val(passive);
    
    $("[name='AnimalHandling_skill']").val(mod);
    $("[name='Insight_skill']").val(mod);
    $("[name='Medicine_skill']").val(mod);
    $("[name='Perception_skill']").val(mod);
    $("[name='Survival_skill']").val(mod);
  }
  
  if(scoreName == "Intelligence")
    {
      $("[name='Arcana_skill']").val(mod);
      $("[name='History_skill']").val(mod);
      $("[name='Investigation_skill']").val(mod);
      $("[name='Nature_skill']").val(mod);
      $("[name='Religion_skill']").val(mod);
    }
  
  if(scoreName == "Charisma")
    {
      $("[name='Deception_skill']").val(mod);
      $("[name='Intimidation_skill']").val(mod);
      $("[name='Performance_skill']").val(mod);
      $("[name='Persuasion_skill']").val(mod);
    }

  if ($("#" + saveProfName +"").attr("checked")) {
    Console.log("Checked");
    var prof = parseInt($("[name='proficiencybonus']").text());
    var scoreName = inputName.slice(0, inputName.indexOf("_save_prof"));
    var saveName = scoreName + "_save";
    var save = parseInt($("[name=']" + saveName + "']").text());
    var newScore = prof + save;
    if (newScore >= 0) newScore = "+" + newScore;
    $("[name='" + saveName + "']").val(newScore);
  }
});

$(".statmod").bind("change", function() {
  var name = $(this).attr("name");
  name = "uses" + name.slice(0, name.indexOf("mod"));
});

$("[name='classlevel']").bind("input", function() {
  var classes = $(this).val();
  var r = new RegExp(/\d+/g);
  var total = 0;
  var result;
  while ((result = r.exec(classes)) != null) {
    var lvl = parseInt(result);
    if (!isNaN(lvl)) total += lvl;
  }
  var cleanprof = 2;
  var prof = cleanprof;
  if (total > 0) {
    total -= 1;
    cleanprof += Math.trunc(total / 4);
    prof = "+" + cleanprof;
  } else {
    prof = "";
  }
  $("[name='proficiencybonus']").val(prof);
});

$("[name='totalhd']").bind("input", function() {
  $("[name='remaininghd']").val($(this).val());
});

$("[name='maxhp']").bind("input", function() {
  
  $("[name='currenthp']").val($(this).val());
});

function totalhd_clicked() {
  $("[name='remaininghd']").val($("[name='totalhd']").val());
}

function maxhp_clicked() {
  console.log("Here");
  $("[name='maxhp']").val($("[name='currenthp']").val());
}

$("[name='Strength_save_prof']").click( function(){
  if($("[name='Strength_save_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Strength_save']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  if(newSave >= 0) newSave = "+" + newSave;
      
$("[name='Strength_save']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Strength_save']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Strength_save']").val(newSave);
    }
}
);

$("[name='Acrobatics_prof']").click( function()
  {
  if($("[name='Acrobatics_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  console.log(prof);
  prof = parseInt(prof, 10);
  console.log(prof);
  var save = $("[name='Acrobatics_skill']").val();
  save = parseInt(save, 10);
  console.log(save);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Acrobatics_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Acrobatics_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Acrobatics_skill']").val(newSave);
    }
}                                 );

$("[name='Animal Handling_prof']").click( function()
  {
  if($("[name='Animal Handling_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='AnimalHandling_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='AnimalHandling_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='AnimalHandling_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='AnimalHandling_skill']").val(newSave);
    }
}                                 );

$("[name='Arcana_prof']").click( function()
  {
  if($("[name='Arcana_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Arcana_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Arcana_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Arcana_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Arcana_skill']").val(newSave);
    }
}                                 );

$("[name='Athletics_prof']").click( function()
  {
  if($("[name='Athletics_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Athletics_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Athletics_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Athletics_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Athletics_skill']").val(newSave);
    }
}                                 );

$("[name='Deception_prof']").click( function()
  {
  if($("[name='Deception_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Deception_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Deception_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Deception_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Deception_skill']").val(newSave);
    }
}                                 );

$("[name='History_prof']").click( function()
  {
  if($("[name='History_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='History_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='History_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='History_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='History_skill']").val(newSave);
    }
}                                 );

$("[name='Insight_prof']").click( function()
  {
  if($("[name='Insight_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Insight_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Insight_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Insight_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Insight_skill']").val(newSave);
    }
}                                 );

$("[name='Intimidation_prof']").click( function()
  {
  if($("[name='Intimidation_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Intimidation_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Intimidation_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Intimidation_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Intimidation_skill']").val(newSave);
    }
}                                 );

$("[name='Investigation_prof']").click( function()
  {
  if($("[name='Investigation_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Investigation_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Investigation_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Investigation_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Investigation_skill']").val(newSave);
    }
}                                 );

$("[name='Medicine_prof']").click( function()
  {
  if($("[name='Medicine_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Medicine_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Medicine_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Medicine_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Medicine_skill']").val(newSave);
    }
}                                 );

$("[name='Nature_prof']").click( function()
  {
  if($("[name='Nature_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Nature_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Nature_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Nature_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Nature_skill']").val(newSave);
    }
}                                 );

$("[name='Perception_prof']").click( function()
  {
  if($("[name='Perception_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Perception_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Perception_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Perception_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Perception_skill']").val(newSave);
    }
}                                 );

$("[name='Performance_prof']").click( function()
  {
  if($("[name='Performance_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Performance_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Performance_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Performance_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Performance_skill']").val(newSave);
    }
}                                 );

$("[name='Persuasion_prof']").click( function()
  {
  if($("[name='Persuasion_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Persuasion_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Persuasion_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Persuasion_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Persuasion_skill']").val(newSave);
    }
}                                 );

$("[name='Religion_prof']").click( function()
  {
  if($("[name='Religion_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Religion_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Religion_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Religion_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Religion_skill']").val(newSave);
    }
}                                 );

$("[name='Sleight of Hand_prof']").click( function()
  {
  if($("[name='Sleight of Hand_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='SleightofHand_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='SleightofHand_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='SleightofHand_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='SleightofHand_skill']").val(newSave);
    }
}                                 );

$("[name='Stealth_prof']").click( function()
  {
  if($("[name='Stealth_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Stealth_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Stealth_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Stealth_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Stealth_skill']").val(newSave);
    }
}                                 );

$("[name='Survival_prof']").click( function()
  {
  if($("[name='Survival_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
  var save = $("[name='Survival_skill']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  console.log(newSave);
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Survival_skill']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Survival_skill']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Survival_skill']").val(newSave);
    }
}                                 );

$("[name='Dexterity_save_prof']").click( function()
{
  if($("[name='Dexterity_save_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Dexterity_save']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  if(newSave >= 0) newSave = "+" + newSave;
  
  $("[name='Dexterity_save']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Dexterity_save']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Dexterity_save']").val(newSave);
    }
}                                      );

$("[name='Constitution_save_prof']").click( function()
{
  if($("[name='Constitution_save_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Constitution_save']").val();
save = parseInt(save, 10);
  var newSave = prof + save;
  if(newSave >= 0) newSave = "+" + newSave;

  $("[name='Constitution_save']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Constitution_save']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Constitution_save']").val(newSave);
    }
}                                      );  

$("[name='Wisdom_save_prof']").click( function()
{
  if($("[name='Wisdom_save_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Wisdom_save']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  if(newSave >= 0) newSave = "+" + newSave;

  $("[name='Wisdom_save']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Wisdom_save']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Wisdom_save']").val(newSave);
    }
}                                      );  

$("[name='Intelligence_save_prof']").click( function()
{
  if($("[name='Intelligence_save_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Intelligence_save']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  if(newSave >= 0) newSave = "+" + newSave;

  $("[name='Intelligence_save']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Intelligence_save']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Intelligence_save']").val(newSave);
    }
}                                      );

$("[name='Charisma_save_prof']").click( function()
{
  if($("[name='Charisma_save_prof']").is(':checked'))
    {
  var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Charisma_save']").val();
  save = parseInt(save, 10);
  var newSave = prof + save;
  if(newSave >= 0) newSave = "+" + newSave;

  $("[name='Charisma_save']").val(newSave);
    }
  else
    {
      var prof = $("[name='proficiencybonus']").val();
  prof = parseInt(prof, 10);
var save = $("[name='Charisma_save']").val();
  save = parseInt(save, 10);
      console.log(save);
  var newSave = save - prof;
  if(newSave >= 0) newSave = "+" + newSave;
   
      $("[name='Charisma_save']").val(newSave);
    }
}                                      );