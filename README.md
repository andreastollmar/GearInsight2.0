# GearInsight

//BILD
        //F�r att f� ut en bild fr�n RequestResult<ItemMedia> media = await warcraftClient.GetItemMediaAsync(200337, "static-eu");
        //S� m�ste vi v�lja Assets > d.Value.AbsoluteUri
        // RequestResult<CharacterMediaSummary> charMedia = await warcraftClient.GetCharacterMediaSummaryAsync(realm, character, "profile-eu"); Asset, render[3 eller 4] f�r storbild av charact�r
        // https://www.wowhead.com/tooltips l�nk f�r wowhead tips

        //
        // 2handed eller mainhand = indexeringen i listan �r 14
        // offhand = index 15
        // tabard = index 16



        // Refresh "knapp"
        // Task<Character> refresh = Mongo.RefreshData(character, realm);
        // await refresh;

        L�gga till bild nr 3 ist�llet f�r 2 f�r character image (BackgroundImage)

        hitta backgrund f�r alla classer? eller ska vi ta en fast background? 

        la till grids f�r allt typ f�r att visa characters, v�vde in allt s� att det g�r att flytta p� etc

        best�mma om vi vill ha itemsen mot mitten eller mot kanterna (byta p� ena griden)