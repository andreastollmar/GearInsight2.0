# GearInsight

//BILD
        //För att få ut en bild från RequestResult<ItemMedia> media = await warcraftClient.GetItemMediaAsync(200337, "static-eu");
        //Så måste vi välja Assets > d.Value.AbsoluteUri
        // RequestResult<CharacterMediaSummary> charMedia = await warcraftClient.GetCharacterMediaSummaryAsync(realm, character, "profile-eu"); Asset, render[3 eller 4] för storbild av charactär
        // https://www.wowhead.com/tooltips länk för wowhead tips

        //
        // 2handed eller mainhand = indexeringen i listan är 14
        // offhand = index 15
        // tabard = index 16



        // Refresh "knapp"
        // Task<Character> refresh = Mongo.RefreshData(character, realm);
        // await refresh;

        Lägga till bild nr 3 istället för 2 för character image (BackgroundImage)

        hitta backgrund för alla classer? eller ska vi ta en fast background? 

        la till grids för allt typ för att visa characters, vävde in allt så att det går att flytta på etc

        bestämma om vi vill ha itemsen mot mitten eller mot kanterna (byta på ena griden)