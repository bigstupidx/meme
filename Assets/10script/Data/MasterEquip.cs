﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EQUIP_TYPE{
	WEAPON		= 0,
	ARMOR		,
	ACCESSARY	,
};

public class MasterEquipParam : CsvDataParam
{
	public int equip_id { get; set; }
	public int equip_type { get; set; }
	public string check_equip_type { get; set; }
	public string name { get; set; }
	public string description { get; set; }
	public int atk { get; set; }
	public int def { get; set; }
	public int mat { get; set; }
	public int mdf { get; set; }
	public int agi { get; set; }
	public int dex { get; set; }
	public int eva { get; set; }
	public int cri { get; set; }
	public int luc { get; set; }
	public int att_fire { get; set; }
	public int att_water { get; set; }
	public int att_wind { get; set; }
	public int att_eath { get; set; }
	public int att_time { get; set; }
}

public class MasterEquip : CsvData<MasterEquipParam> {
	public const string SPREAD_SHEET_PAGE = "14NT9a0VRO4xSK2SEupSxg4_fqoSMNoD1U69BKF228CM";
	public const string SPREAD_SHEET_ID = "od6";
	private Dictionary<int, MasterEquipParam> dict = new Dictionary<int, MasterEquipParam>();

	public MasterEquipParam Get( int _iEquipId)
	{
		MasterEquipParam retParam = null;
		dict.TryGetValue(_iEquipId, out retParam);
		return retParam;
	}

	private void SetupDict()
	{
		dict.Clear();
		foreach (MasterEquipParam param in list)
		{
			dict.Add(param.equip_id, param);
		}
	}

	protected override void afterRecievedSpreadSheet()
	{
		base.afterRecievedSpreadSheet();
		SetupDict();
	}
}



