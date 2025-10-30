using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DesktopApplications.Models.Classes;
using HtmlAgilityPack;
using Newtonsoft.Json.Linq;

namespace DesktopApplications.Models;

public class RecipeParser
{
    
    public async Task ParseFromLink(string link)
    {
        //create proper uri from link string
        if(!Uri.TryCreate(link, UriKind.Absolute, out var uri))
            throw new UriFormatException("Invalid URL format.");
        
        //parse all html from page
        using HttpClient http = new HttpClient();
        string html = await http.GetStringAsync(uri);
        
        var document = new HtmlDocument();
        document.LoadHtml(html);

        var recipe = TryParseJson(document);

        if (string.IsNullOrEmpty(recipe))
        {
            recipe = TryParseHtml(document);
        }
        
       
     
    }


    private string TryParseHtml(HtmlDocument document)
    {
        return string.Empty;
    }


    private string TryParseJson(HtmlDocument document)
    {
        //find recipe json from page
        var scripts = document.DocumentNode.SelectNodes("//script[@type='application/ld+json']");
        if (scripts == null)
            throw new Exception("No recipe data found on the page.");

        //look for recipe data in scripts
        foreach (var script in scripts)
        {
            try
            {
                var json = script.InnerText.Trim();
                var token = JToken.Parse(json);

                var recipeNode = token.Type switch
                {
                    JTokenType.Array => token.FirstOrDefault(t => t["@type"]?.ToString().Contains("Recipe") == true),
                    _ => token["@type"]?.ToString().Contains("Recipe") == true ? token : null
                };

                if (recipeNode == null)
                {
                    Console.WriteLine("not found");
                    continue;
                }

                string Name = recipeNode["name"]?.ToString() ?? "Unknown recipe";
                Console.WriteLine(Name);
                string Description = recipeNode["description"]?.ToString();
                Console.WriteLine(Description);
                string TotalTime = recipeNode["totalTime"]?.ToString();
                Console.WriteLine(TotalTime);
                List<string> Ingredients = recipeNode["recipeIngredient"]?.ToObject<List<string>>() ?? new List<string>();
                foreach (string ingredient in Ingredients)
                {
                    Console.WriteLine(ingredient);
                }


                Console.WriteLine("Creating json");

            }
            catch
            {
                continue;
            }
        }

        return string.Empty;
    }
}