#!/usr/bin/env python

class WoundCalculator:
    def __init__(self):
        self.show_welcome_msg()
        self.init_variables()
        self.loop()

    def init_variables(self):
        self.nb_attack = 0.0
        self.CT_CC = 0.0
        self.nb_hit = 0.0
        self.strength = 0.0
        self.target_toughness = 0.0
        self.wound_throw = 0.0
        self.wound = 0.0
        self.AP = 0.0
        self.save = 0.0
        self.invulnerable_save = 0.0
        self.unsaved_wound = 0.0

        self.hit_bonus = 0.0
        self.wound_bonus = 0.0
        self.save_bonus = 0.0


    def show_welcome_msg(self):
        pass

    def loop(self):
        while(1):
            print
            print "##############################"
            print
            self.nb_attack = float(input("Nb of attac / shoot : "))
            self.CT_CC = float(input("CT / CC : "))
            self.hit_bonus = float(input("Hit bonus ? (- if malus) : "))
            self.nb_hit = self.nb_attack * ((7 - self.CT_CC + self.hit_bonus)/6)
            print
            print "     => hit = ", self.nb_hit
            print
            self.strength = float(input("Attack strength : "))
            self.target_toughness = float(input("Target toughness : "))
            self.wound_bonus = float(input("Wound bonus ? (- if malus) : "))
            self.wound_throw = self.calculate_wound(self.strength, self.target_toughness)
            self.wound = self.wound_throw * self.nb_hit
            print
            print "     => wound = ",self.wound
            print
            self.AP = float(input("Weapons AP : -"))
            self.save = float(input("Target save : "))
            self.invulnerable_save = float(input("Target invulnerable save (0 if none): "))
            self.save_bonus = float(input("save bonus ? (- if malus) : "))
            self.calculate_save()
            print
            print "     => nb unsaved wound = ",self.unsaved_wound
            print


    def calculate_wound(self, strength, toughness):
        wound_factor = 0.0
        ratio = toughness / strength    
        if (ratio == 1.0):
            wound_factor = ((3.0 + self.wound_bonus) / 6.0)
            print(wound_factor)
        if (0.5 < ratio < 1.0): # T < S
            wound_factor = 4.0 / 6.0 # = 4/6
        if (ratio <= 0.5): # T < 2 xS
            wound_factor = 5.0 / 6.0 #5/6
        if 1.0 < ratio < 2.0    : #T > S
            wound_factor = 2.0 / 6.0 # = 2/6
        if (ratio >= 2.0): # T > 2x S
            wound_factor = 1.0 / 6.0 # = 1/6
        return wound_factor

    def calculate_save(self):
        self.save = self.AP + self.save - self.save_bonus
        self.unsaved_wound = 0.0
        if(self.invulnerable_save < self.save and self.invulnerable_save > 0):
            print ("sauvegarde invul !")
            self.unsaved_wound = self.wound * (1 - ((7 - self.invulnerable_save)/6))
        elif(self.save <= 6):
            print("save classique")
            self.unsaved_wound = self.wound * (1 - ((7 - self.save)/6))
        else:
            print("pas de save")
            self.unsaved_wound = self.wound
        return






    

if __name__ == '__main__':
    c = WoundCalculator()
