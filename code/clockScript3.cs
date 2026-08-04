// Solar System Clock Example Script
// Copyright (C) 2026 Radu G. Balaban G.  

// This program is free software: you can redistribute it and/or modify  
// it under the terms of the GNU General Public License as published by  
// the Free Software Foundation, either version 3 of the License, or  
// (at your option) any later version.  

// This program is distributed in the hope that it will be useful,  
// but WITHOUT ANY WARRANTY; without even the implied warranty of  
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the  
// GNU General Public License for more details.  

// You should have received a copy of the GNU General Public License  
// along with this program. If not, see <https://www.gnu.org/licenses/>.  


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clockScript3 : MonoBehaviour
{

	[SerializeField] GameObject MercuryPlanet, VenusPlanet, EarthPlanet, MarsPlanet, JupiterPlanet, SaturnPlanet, UranusPlanet, NeptunePlanet, PlutoPlanet;
	[SerializeField] GameObject MercuryOrbit, VenusOrbit, EarthOrbit, MarsOrbit, JupiterOrbit, SaturnOrbit, UranusOrbit, NeptuneOrbit, PlutoOrbit;
	

	[SerializeField] Text MercuryDayText, VenusDayText, EarthDayText, MarsDayText, JupiterDayText, SaturnDayText, UranusDayText, NeptuneDayText, PlutoDayText;
	[SerializeField] Text MercuryYearText, VenusYearText, EarthYearText, MarsYearText, JupiterYearText, SaturnYearText, UranusYearText, NeptuneYearText, PlutoYearText;


    [SerializeField] GameObject MercuryPlanet2, VenusPlanet2, EarthPlanet2, MarsPlanet2, JupiterPlanet2, SaturnPlanet2, UranusPlanet2, NeptunePlanet2, PlutoPlanet2;
	[SerializeField] GameObject MercuryOrbit2, VenusOrbit2, EarthOrbit2, MarsOrbit2, JupiterOrbit2, SaturnOrbit2, UranusOrbit2, NeptuneOrbit2, PlutoOrbit2;
	
	
	
	
	float speed = 0.1f;
	
	float time = 0;
	
	float MercuryDayDegrees;
	float VenusDayDegrees;
	float EarthDayDegrees;
	float MarsDayDegrees;
	float JupiterDayDegrees;
	float SaturnDayDegrees;
	float UranusDayDegrees;
	float NeptuneDayDegrees;
	float PlutoDayDegrees;
	
	float MercuryYearDegrees;
	float VenusYearDegrees;
	float EarthYearDegrees;
	float MarsYearDegrees;
	float JupiterYearDegrees;
	float SaturnYearDegrees;
	float UranusYearDegrees;
	float NeptuneYearDegrees;
	float PlutoYearDegrees;
	
	float MercuryDayRotation, VenusDayRotation, EarthDayRotation, MarsDayRotation, JupiterDayRotation, SaturnDayRotation, UranusDayRotation, NeptuneDayRotation, PlutoDayRotation;
	float MercuryYearRotation, VenusYearRotation, EarthYearRotation, MarsYearRotation, JupiterYearRotation, SaturnYearRotation, UranusYearRotation, NeptuneYearRotation, PlutoYearRotation;
	
	int MercuryDayCount, VenusDayCount, EarthDayCount, MarsDayCount, JupiterDayCount, SaturnDayCount, UranusDayCount, NeptuneDayCount, PlutoDayCount;
	int MercuryYearCount, VenusYearCount, EarthYearCount, MarsYearCount, JupiterYearCount, SaturnYearCount, UranusYearCount, NeptuneYearCount, PlutoYearCount;
	
    // Start is called before the first frame update
    void Start()
    {
    
    	MercuryDayDegrees = 360 / 1408;
    	VenusDayDegrees = 360 / 5832;
    	EarthDayDegrees = 360 / 24;
    	MarsDayDegrees = 360 / 25;
    	JupiterDayDegrees = 360 / 10;
    	SaturnDayDegrees = 360 / 11;
    	UranusDayDegrees = 360 / 17;
    	NeptuneDayDegrees = 360 / 16;
    	PlutoDayDegrees = 360 / 153;
    	
    	MercuryYearDegrees = 360 / ( 24 * 88 );
    	VenusYearDegrees = 360 / ( 24 * 225 );
    	EarthYearDegrees = 360 / ( 24 * 365.25f );
    	MarsYearDegrees = 360 / ( 24 * 687 );
    	JupiterYearDegrees = 360 / ( 24 * 365.25f * 12);
    	SaturnYearDegrees = 360 / ( 24 * 365.25f * 29.5f );
    	UranusYearDegrees = 360 / ( 24 * 365.25f * 84 );
    	NeptuneYearDegrees = 360 / ( 24 * 365.25f * 165 );
    	PlutoYearDegrees = 360 / ( 24 * 365.25f * 248 );
    	
    	
      
        

        MercuryDayText.text = MercuryDayCount.ToString();
        VenusDayText.text = VenusDayCount.ToString();
        EarthDayText.text = EarthDayCount.ToString();
        MarsDayText.text = MarsDayCount.ToString();
        JupiterDayText.text = JupiterDayCount.ToString();
        SaturnDayText.text = SaturnDayCount.ToString();
        UranusDayText.text = UranusDayCount.ToString();
        NeptuneDayText.text = NeptuneDayCount.ToString();
        PlutoDayText.text = PlutoDayCount.ToString();

        MercuryYearText.text = MercuryYearCount.ToString();
        VenusYearText.text = VenusYearCount.ToString();
        EarthYearText.text = EarthYearCount.ToString();
        MarsYearText.text = MarsYearCount.ToString();
        JupiterYearText.text = JupiterYearCount.ToString();
        SaturnYearText.text = SaturnYearCount.ToString();
        UranusYearText.text = UranusYearCount.ToString();
        NeptuneYearText.text = NeptuneYearCount.ToString();
        PlutoYearText.text = PlutoYearCount.ToString();

    }

    // Update is called once per frame
    void Update()
    {
    
    	//Sunlight.intensity = 1;
    	
    	//time += Time.deltaTime;
        
        //float interval = Random.Range(3,5);
        
        
        
        //if(time >= interval){
        
        //time=0;
        //Sunlight.intensity = 0;
        
        //}
        
        MercuryPlanet.transform.Rotate(0,0,-MercuryDayDegrees * speed);
        MercuryOrbit.transform.Rotate(0,0,-MercuryYearDegrees * speed);

        MercuryPlanet2.transform.Rotate(0,0,-MercuryDayDegrees * speed);
        MercuryOrbit2.transform.Rotate(0,0,-MercuryYearDegrees * speed);
      
        
        MercuryDayRotation += ( MercuryDayDegrees * speed );
        MercuryYearRotation += ( MercuryYearDegrees * speed );
        
        if(MercuryDayRotation > 360){ MercuryDayCount += 1; MercuryDayRotation -= 360; MercuryDayText.text = MercuryDayCount.ToString(); }
        if(MercuryYearRotation > 360){ MercuryYearCount += 1; MercuryYearRotation -= 360; MercuryYearText.text = MercuryYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        VenusPlanet.transform.Rotate(0,0,VenusDayDegrees * speed);
        VenusOrbit.transform.Rotate(0,0,-VenusYearDegrees * speed);

        VenusPlanet2.transform.Rotate(0,0,VenusDayDegrees * speed);
        VenusOrbit2.transform.Rotate(0,0,-VenusYearDegrees * speed);
    
        
        VenusDayRotation += ( VenusDayDegrees * speed );
        VenusYearRotation += ( VenusYearDegrees * speed );
        
        if(VenusDayRotation > 360){ VenusDayCount += 1; VenusDayRotation -= 360; VenusDayText.text = VenusDayCount.ToString(); }
        if(VenusYearRotation > 360){ VenusYearCount += 1; VenusYearRotation -= 360; VenusYearText.text = VenusYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        EarthPlanet.transform.Rotate(0,0,-EarthDayDegrees * speed);
        EarthOrbit.transform.Rotate(0,0,-EarthYearDegrees * speed);

        EarthPlanet2.transform.Rotate(0,0,-EarthDayDegrees * speed);
        EarthOrbit2.transform.Rotate(0,0,-EarthYearDegrees * speed);
       
        
        EarthDayRotation += ( EarthDayDegrees * speed );
        EarthYearRotation += ( EarthYearDegrees * speed );
        
        if(EarthDayRotation > 360){ EarthDayCount += 1; EarthDayRotation -= 360; EarthDayText.text = EarthDayCount.ToString(); }
        if(EarthYearRotation > 360){ EarthYearCount += 1; EarthYearRotation -= 360; EarthYearText.text = EarthYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        MarsPlanet.transform.Rotate(0,0,-MarsDayDegrees * speed);
        MarsOrbit.transform.Rotate(0,0,-MarsYearDegrees * speed);

        MarsPlanet2.transform.Rotate(0,0,-MarsDayDegrees * speed);
        MarsOrbit2.transform.Rotate(0,0,-MarsYearDegrees * speed);
      
        
        MarsDayRotation += ( MarsDayDegrees * speed );
        MarsYearRotation += ( MarsYearDegrees * speed );
        
        if(MarsDayRotation > 360){ MarsDayCount += 1; MarsDayRotation -= 360; MarsDayText.text = MarsDayCount.ToString(); }
        if(MarsYearRotation > 360){ MarsYearCount += 1; MarsYearRotation -= 360; MarsYearText.text = MarsYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        JupiterPlanet.transform.Rotate(0,0,-JupiterDayDegrees * speed);
        JupiterOrbit.transform.Rotate(0,0,-JupiterYearDegrees * speed);
        

        JupiterPlanet2.transform.Rotate(0,0,-JupiterDayDegrees * speed);
        JupiterOrbit2.transform.Rotate(0,0,-JupiterYearDegrees * speed);
       
        
        JupiterDayRotation += ( JupiterDayDegrees * speed );
        JupiterYearRotation += ( JupiterYearDegrees * speed );
        
        if(JupiterDayRotation > 360){ JupiterDayCount += 1; JupiterDayRotation -= 360; JupiterDayText.text = JupiterDayCount.ToString(); }
        if(JupiterYearRotation > 360){ JupiterYearCount += 1; JupiterYearRotation -= 360; JupiterYearText.text = JupiterYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        SaturnPlanet.transform.Rotate(0,0,-SaturnDayDegrees * speed);
        SaturnOrbit.transform.Rotate(0,0,-SaturnYearDegrees * speed);
        
        SaturnPlanet2.transform.Rotate(0,0,-SaturnDayDegrees * speed);
        SaturnOrbit2.transform.Rotate(0,0,-SaturnYearDegrees * speed);
        
        SaturnDayRotation += ( SaturnDayDegrees * speed );
        SaturnYearRotation += ( SaturnYearDegrees * speed );
        
        if(SaturnDayRotation > 360){ SaturnDayCount += 1; SaturnDayRotation -= 360; SaturnDayText.text = SaturnDayCount.ToString(); }
        if(SaturnYearRotation > 360){ SaturnYearCount += 1; SaturnYearRotation -= 360; SaturnYearText.text = SaturnYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        UranusPlanet.transform.Rotate(0,0,UranusDayDegrees * speed);
        UranusOrbit.transform.Rotate(0,0,-UranusYearDegrees * speed);
        

        UranusPlanet2.transform.Rotate(0,0,UranusDayDegrees * speed);
        UranusOrbit2.transform.Rotate(0,0,-UranusYearDegrees * speed);
      
        
        UranusDayRotation += ( UranusDayDegrees * speed );
        UranusYearRotation += ( UranusYearDegrees * speed );
        
        if(UranusDayRotation > 360){ UranusDayCount += 1; UranusDayRotation -= 360; UranusDayText.text = UranusDayCount.ToString(); }
        if(UranusYearRotation > 360){ UranusYearCount += 1; UranusYearRotation -= 360; UranusYearText.text = UranusYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        NeptunePlanet.transform.Rotate(0,0,-NeptuneDayDegrees * speed);
        NeptuneOrbit.transform.Rotate(0,0,-NeptuneYearDegrees * speed);
       
        NeptunePlanet2.transform.Rotate(0,0,-NeptuneDayDegrees * speed);
        NeptuneOrbit2.transform.Rotate(0,0,-NeptuneYearDegrees * speed);
        
        NeptuneDayRotation += ( NeptuneDayDegrees * speed );
        NeptuneYearRotation += ( NeptuneYearDegrees * speed );
        
        if(NeptuneDayRotation > 360){ NeptuneDayCount += 1; NeptuneDayRotation -= 360; NeptuneDayText.text = NeptuneDayCount.ToString(); }
        if(NeptuneYearRotation > 360){ NeptuneYearCount += 1; NeptuneYearRotation -= 360; NeptuneYearText.text = NeptuneYearCount.ToString(); }
        
        //////////////////////////////////////////////////////////////////////////////////
        
        PlutoPlanet.transform.Rotate(0,0,-PlutoDayDegrees * speed);
        PlutoOrbit.transform.Rotate(0,0,-PlutoYearDegrees * speed);
        
      
        PlutoPlanet2.transform.Rotate(0,0,-PlutoDayDegrees * speed);
        PlutoOrbit2.transform.Rotate(0,0,-PlutoYearDegrees * speed);
        
        PlutoDayRotation += ( PlutoDayDegrees * speed );
        PlutoYearRotation += ( PlutoYearDegrees * speed );
        
        if(PlutoDayRotation > 360){ PlutoDayCount += 1; PlutoDayRotation -= 360; PlutoDayText.text = PlutoDayCount.ToString(); }
        if(PlutoYearRotation > 360){ PlutoYearCount += 1; PlutoYearRotation -= 360; PlutoYearText.text = PlutoYearCount.ToString(); }
        



    }
}
