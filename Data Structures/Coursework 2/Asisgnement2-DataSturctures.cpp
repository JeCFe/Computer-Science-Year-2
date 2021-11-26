#include <vector> //only to be used to contain dispenser states and nothing else
#include <iostream>
#include <string>

using namespace std;

enum state { NO_NPCS, NO_RESOURCES, HAVE_RESOURCES, SPAWN_NPC };
enum stateParameter { NPCS, RESOURCES };

class StateContext;

class State
{
protected:

	StateContext* CurrentContext;

public:

	State(StateContext* Context)
	{
		CurrentContext = Context;
	}
	virtual ~State(void)
	{
	}

};

class StateContext
{
protected:

	State* CurrentState = nullptr;
	int stateIndex = 0;
	vector<State*> availableStates;
	vector<int> stateParameters;

public:

	virtual ~StateContext()
	{
		for (int index = 0; index < this->availableStates.size(); index++) delete this->availableStates[index];
		this->availableStates.clear();
		this->stateParameters.clear();
	}

	virtual void setState(state newState)
	{
		this->CurrentState = availableStates[newState];
		this->stateIndex = newState;
	}

	virtual int getStateIndex(void)
	{
		return this->stateIndex;
	}

	virtual void setStateParam(stateParameter SP, int value)
	{
		this->stateParameters[SP] = value;
	}

	virtual int getStateParam(stateParameter SP)
	{
		return this->stateParameters[SP];
	}
};

class Transition
{
public:
	virtual bool addResource(int) { cout << "Error!" << endl; return false; }
	virtual bool makeSelection(int) { cout << "Error!" << endl; return false; }
	virtual bool returnResource(void) { cout << "Error!" << endl; return false; }
	virtual bool addNPCs(int) { cout << "Error!" << endl; return false; }
	virtual bool spawn(void) { cout << "Error!" << endl; return false; }
};

class NPCState : public State, public Transition
{
public:
	NPCState(StateContext* Context) : State(Context) {}
};

class NoNPCs : public NPCState
{
public:
	NoNPCs(StateContext* Context) : NPCState(Context) {}
	bool addResource(int resource);
	bool makeSelection(int option);
	bool returnResource(void);
	bool addNPCs(int number);
	bool spawn(void);
};

class NoResources : public NPCState
{
public:
	NoResources(StateContext* Context) : NPCState(Context) {}
	bool addResource(int resource);
	bool makeSelection(int option);
	bool returnResource(void);
	bool addNPCs(int number);
	bool spawn(void);
};

class HaveResources : public NPCState
{
public:
	HaveResources(StateContext* Context) : NPCState(Context) {}
	bool addResource(int resource);
	bool makeSelection(int option);
	bool returnResource(void);
	bool addNPCs(int number);
	bool spawn(void);
};

class SpawnNPC : public NPCState
{
public:
	SpawnNPC(StateContext* Context) : NPCState(Context) {}
	bool addResource(int resource);
	bool makeSelection(int option);
	bool returnResource(void);
	bool addNPCs(int number);
	bool spawn(void);
};


class Weapon;

class NPC
{
protected:
	string _description = "NPC";
	int _cost = 0;
	int _damage = 0;
public:
	string description(void) { return this->_description; };
	int cost(void) { return this->_cost; }
	int damage(void) { return this->_damage; }
	virtual int bestDamage(int best_weapon_damage = 0); //returns the best damage an NPC can do - i.e. base damage + highest damage weapon. Should return 0 if not implemented
	virtual int costAll(void) { return this->cost(); } //returns NPC base cost
	virtual string describeAll(void) { return this->description(); } //returns description of NPC
	virtual Weapon* ReturnHighestCostWeapon(void) { return nullptr; } //returns nullptr
};

class Weapon : public NPC
{
protected:
	NPC* FilledNPC = nullptr;
public:
	~Weapon(void);
	void equipNPC(NPC* NewNPC);
	int costAll(void); //returns cost of NPC + all weapons
	int bestDamage(int best_weapon_damage = 0); //returns the best damage an NPC can do - i.e. base damage + highest damage weapon
	string describeAll(void); //returns string description of NPC + all weapons
	Weapon* ReturnHighestCostWeapon(void); //returns a pointer to the high cost weapon. Should return nullptr if not implemented
};

class NPCGenerator : public StateContext, public Transition
{
	friend class SpawnNPC;
	friend class HaveResources;
private:
	NPCState* NPCCurrentState = nullptr;
	bool itemDispensed = false; //indicates whether a NPC is there to be retrieved - needed for ownership managemnt
	NPC* SpawnedNPC = nullptr; //
	bool itemRetrieved = false; //indicates whether a NPC has been retrieved - needed for ownership managemnt
public:
	NPCGenerator(int inventory_count);
	~NPCGenerator(void);
	bool addResource(int resource);
	bool makeSelection(int option);
	bool returnResource(void);
	bool addNPCs(int number);
	bool spawn(void);
	NPC* getNPC(void);
	virtual void setStateParam(stateParameter SP, int value);
	virtual int getStateParam(stateParameter SP);
};

NPCGenerator::~NPCGenerator(void)
{
	if (!this->itemRetrieved)
	{
		delete this->SpawnedNPC;
	}
}

bool NPCGenerator::addResource(int resource)
{
	NPCCurrentState = (NPCState*)this->CurrentState;
	return this->NPCCurrentState->addResource(resource);
}

bool NPCGenerator::makeSelection(int option)
{
	NPCCurrentState = (NPCState*)this->CurrentState;
	return this->NPCCurrentState->makeSelection(option);
}

bool NPCGenerator::returnResource(void)
{
	NPCCurrentState = (NPCState*)this->CurrentState;
	return this->NPCCurrentState->returnResource();
}

bool NPCGenerator::addNPCs(int number)
{
	NPCCurrentState = (NPCState*)this->CurrentState;
	return this->NPCCurrentState->addNPCs(number);
}

bool NPCGenerator::spawn(void)
{
	NPCCurrentState = (NPCState*)this->CurrentState;
	return this->NPCCurrentState->spawn();
}

NPC* NPCGenerator::getNPC(void)
{
	//handles transfer of NPC object ownership
	if (this->itemDispensed)
	{
		this->itemDispensed = false;
		this->itemRetrieved = true;
		return this->SpawnedNPC;
	}

	return nullptr;
}

void NPCGenerator::setStateParam(stateParameter SP, int value)
{
	this->stateParameters[SP] = value;
}

int NPCGenerator::getStateParam(stateParameter SP)
{
	return this->stateParameters[SP];
}
