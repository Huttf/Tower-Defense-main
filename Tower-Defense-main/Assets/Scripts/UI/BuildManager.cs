using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    /*singleton that places towers on valid tiles
        check out shoptscript to view its implementation */
    public static BuildManager single;
    
    /* represents the currently selected tower from the shop */
    private TowerPrefabAndCosts towerToBuild;

    SoundManager soundManage = new SoundManager();

    void Awake(){
        if(single != null){
            Debug.LogError("There is more than one BuildManager");
            return;
        }
        single = this;
    }

    public void SetTowerToBuild(TowerPrefabAndCosts tower){
        towerToBuild = tower;
    }

    // check if there is a non null "blueprint" for a tower selected.
    public bool allowedToBuild(){
        return towerToBuild != null;
    }

    /* an implementation taken from the video for placing the selected tower 
    on a valid tile and subtracting the money from the player's balance.*/
/*
    public void BuildTowerOnTile(Tile tile){

        if(PlayerResources.Gold < towerToBuild.cost){
            Debug.Log ("Not enough gold to build");
            return;
        }
        PlayerResources.Gold -= towerToBuild;
        GameObject tower = (GameObject)Instantiate(towerToBuild.prefab, tile.GetBuildPosition, Quaternion.identity);
        tile.tower = tower;
        if(buildManager.selectedTower == buildManager.knifeTower){
            soundManage.PlaySFX("knifetowerplace");
        } else if(buildManager.selectedTower == buildManager.iceTower){
            soundManage.PlaySFX("icetowerplace");
        }else{
            soundManage.PlaySFX("grilltowerplace");
        }
        Debug.Log("Tower Built, Remaining Gold" + PlayerResources.Gold);
    }
*/

    


    //public bool allowedToBuild {get { return towerToBuild != null } };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
