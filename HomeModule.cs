using Nancy;
using MadLib.Objects;

namespace MadLib
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };

      Get["/story"] = _ => {
        MadLibVariables myMadLibVariables = new MadLibVariables();
        myMadLibVariables.SetAdjective1(Request.Query["adjective1"]);
        myMadLibVariables.SetAdjective2(Request.Query["adjective2"]);
        myMadLibVariables.SetPerson(Request.Query["person"]);
        myMadLibVariables.SetPluralNoun(Request.Query["pluralNoun"]);
        myMadLibVariables.SetNoun1(Request.Query["noun1"]);
        myMadLibVariables.SetNoun2(Request.Query["noun2"]);
        myMadLibVariables.SetVerb(Request.Query["verb"]);
        myMadLibVariables.SetVegetable(Request.Query["vegetable"]);
        myMadLibVariables.SetColor(Request.Query["color"]);
        myMadLibVariables.SetNoun3(Request.Query["noun3"]);
        return View["story.cshtml", myMadLibVariables];
      };
    }
  }
}

// "Nancy": "1.3.0",
