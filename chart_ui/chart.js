// Include the Chart.js library
const data = [
  {
    id: 96,
    asset_type: 'house',
    status: 'rented',
    location: '32149 Lopez Village\nSouth Lisa, SC 89521',
    occupancy_history: [
      {
        id: 70,
        start_date: '1999-07-04',
        end_date: '2013-01-31',
        license_plate: 'N/A',
      },
      {
        id: 25,
        start_date: '2023-04-12',
        end_date: '2019-02-16',
        license_plate: 'N/A',
      },
      {
        id: 42,
        start_date: '1972-09-13',
        end_date: '2021-06-09',
        license_plate: 'N/A',
      },
      {
        id: 20,
        start_date: '1975-06-07',
        end_date: '2002-08-12',
        license_plate: 'N/A',
      },
      {
        id: 30,
        start_date: '1984-04-26',
        end_date: '2023-04-27',
        license_plate: 'N/A',
      },
      {
        id: 26,
        start_date: '2011-11-24',
        end_date: '2012-05-13',
        license_plate: 'N/A',
      },
      {
        id: 29,
        start_date: '1985-03-24',
        end_date: '2008-05-11',
        license_plate: 'N/A',
      },
      {
        id: 21,
        start_date: '1998-11-20',
        end_date: '1977-06-20',
        license_plate: 'N/A',
      },
      {
        id: 96,
        start_date: '2006-12-27',
        end_date: '1981-11-16',
        license_plate: 'N/A',
      },
      {
        id: 18,
        start_date: '2013-10-07',
        end_date: '1991-11-19',
        license_plate: 'N/A',
      },
    ],
    rent_history: [
      {
        id: 69,
        change_date: '1972-07-10',
        amount: 1153.68,
      },
      {
        id: 28,
        change_date: '2017-05-25',
        amount: 1776.88,
      },
      {
        id: 79,
        change_date: '2014-11-20',
        amount: 744.85,
      },
    ],
    damage_history: [
      {
        id: 82,
        description:
          'Yet level wear fact answer difficult perhaps first. Region five evidence. Natural yet seem serve.',
        date_reported: '1983-06-23',
      },
      {
        id: 87,
        description: 'Role yes view. Threat college either she. Happy one whether side live measure control girl.',
        date_reported: '1996-03-02',
      },
      {
        id: 18,
        description: 'Call page officer plan one state game. Itself challenge rich wonder collection.',
        date_reported: '2007-04-02',
      },
      {
        id: 11,
        description: 'No consider before movie remember three nation. Task fund enough popular.',
        date_reported: '2005-05-15',
      },
      {
        id: 40,
        description: 'Wide let involve one close special test. Institution form west step answer.',
        date_reported: '1976-05-12',
      },
    ],
    appliances: [
      {
        id: 23,
        brand: 'Kelly LLC',
        model: 'Model Z',
      },
      {
        id: 83,
        brand: 'Russell, Cervantes and Dougherty',
        model: 'Model Y',
      },
      {
        id: 95,
        brand: 'Garcia LLC',
        model: 'Model Z',
      },
      {
        id: 85,
        brand: 'Pugh-Joseph',
        model: 'Model Y',
      },
      {
        id: 54,
        brand: 'Lynch, Patton and Clark',
        model: 'Model X',
      },
    ],
  },
  {
    id: 22,
    asset_type: 'parking-spot',
    status: 'available',
    location: '69663 Wright Drive\nNorth Cassandrafurt, VA 67256',
    occupancy_history: [
      {
        id: 80,
        start_date: '2020-03-21',
        end_date: '1973-05-20',
        license_plate: 'TVO 858',
      },
      {
        id: 69,
        start_date: '2006-09-18',
        end_date: '2019-01-01',
        license_plate: 'EXQ-492',
      },
      {
        id: 43,
        start_date: '2000-07-12',
        end_date: '1985-10-25',
        license_plate: '468 UD1',
      },
      {
        id: 45,
        start_date: '1976-06-10',
        end_date: '2008-05-18',
        license_plate: '7Q QV608',
      },
      {
        id: 25,
        start_date: '1989-03-26',
        end_date: '1998-03-22',
        license_plate: '309XSZ',
      },
      {
        id: 22,
        start_date: '2022-05-08',
        end_date: '1992-11-30',
        license_plate: '399-TQE',
      },
      {
        id: 93,
        start_date: '2022-08-29',
        end_date: '2019-10-30',
        license_plate: '0-01231',
      },
      {
        id: 29,
        start_date: '2014-05-04',
        end_date: '1993-12-26',
        license_plate: '95E NN8',
      },
      {
        id: 37,
        start_date: '1994-11-05',
        end_date: '2002-08-24',
        license_plate: 'HZE 910',
      },
      {
        id: 61,
        start_date: '1995-07-17',
        end_date: '1988-01-12',
        license_plate: 'KFG-946',
      },
    ],
    rent_history: [
      {
        id: 44,
        change_date: '2011-03-31',
        amount: 457.79,
      },
      {
        id: 4,
        change_date: '2011-07-19',
        amount: 355.2,
      },
      {
        id: 82,
        change_date: '2007-07-17',
        amount: 1347.91,
      },
    ],
    damage_history: [
      {
        id: 47,
        description: 'East around laugh. Stuff candidate well beyond fire.',
        date_reported: '2015-06-17',
      },
      {
        id: 75,
        description: 'Woman dinner maintain use trade. Quickly hotel anything.',
        date_reported: '1972-03-12',
      },
      {
        id: 83,
        description: 'Show strategy choice structure. Mind hotel rest per memory three. Worry partner reason want yes.',
        date_reported: '2015-10-06',
      },
      {
        id: 19,
        description: 'Item current two audience three discuss discussion relationship. Its score investment main.',
        date_reported: '2020-11-03',
      },
      {
        id: 48,
        description: 'Market military campaign next there. Build way happen second others heart fight.',
        date_reported: '1970-11-28',
      },
    ],
    appliances: [
      {
        id: 99,
        brand: 'Smith Ltd',
        model: 'Model Z',
      },
      {
        id: 85,
        brand: 'May-Gray',
        model: 'Model Z',
      },
      {
        id: 56,
        brand: 'West, Calderon and Thompson',
        model: 'Model Z',
      },
      {
        id: 77,
        brand: 'Lopez, Baker and Dyer',
        model: 'Model X',
      },
      {
        id: 92,
        brand: 'Baker, Thomas and Mendez',
        model: 'Model X',
      },
    ],
  },
  {
    id: 45,
    asset_type: 'parking-spot',
    status: 'available',
    location: '3889 Rubio Branch\nHansenton, MI 45817',
    occupancy_history: [
      {
        id: 79,
        start_date: '2018-09-04',
        end_date: '1972-05-21',
        license_plate: 'ZYR 287',
      },
      {
        id: 11,
        start_date: '1987-06-21',
        end_date: '1991-09-19',
        license_plate: '79Z 5479',
      },
      {
        id: 14,
        start_date: '1990-09-30',
        end_date: '1975-07-21',
        license_plate: '537-GZH',
      },
      {
        id: 47,
        start_date: '2014-06-24',
        end_date: '1991-10-03',
        license_plate: '9JC8308',
      },
      {
        id: 89,
        start_date: '2011-07-11',
        end_date: '2021-06-12',
        license_plate: '33ST6',
      },
      {
        id: 48,
        start_date: '1983-10-21',
        end_date: '1978-01-26',
        license_plate: 'SZU 122',
      },
      {
        id: 1,
        start_date: '1987-06-16',
        end_date: '1985-03-05',
        license_plate: '332 WLF',
      },
      {
        id: 20,
        start_date: '2021-03-27',
        end_date: '1991-07-11',
        license_plate: '785 NP0',
      },
      {
        id: 41,
        start_date: '2003-07-02',
        end_date: '2021-03-21',
        license_plate: '455 RMQ',
      },
      {
        id: 26,
        start_date: '2006-02-11',
        end_date: '2000-07-12',
        license_plate: '985-ATTM',
      },
    ],
    rent_history: [
      {
        id: 83,
        change_date: '2000-08-20',
        amount: 845.5,
      },
      {
        id: 33,
        change_date: '1970-05-14',
        amount: 353.23,
      },
      {
        id: 65,
        change_date: '2016-08-11',
        amount: 779.88,
      },
    ],
    damage_history: [
      {
        id: 49,
        description: 'Last source writer important piece care. Whose possible international whether moment.',
        date_reported: '1998-12-04',
      },
      {
        id: 84,
        description: 'Clear city improve because worry society protect investment. Direction relate agree.',
        date_reported: '1999-08-01',
      },
      {
        id: 48,
        description: 'Cell raise section member as live power. Since minute book throughout beautiful face.',
        date_reported: '2002-02-24',
      },
      {
        id: 85,
        description: 'Know deal close Republican. Only federal place discuss piece west official everyone.',
        date_reported: '2012-10-02',
      },
      {
        id: 54,
        description: 'Letter effort great. Very many month Congress. Fish also recent reality piece billion her.',
        date_reported: '1994-12-05',
      },
    ],
    appliances: [
      {
        id: 21,
        brand: 'Freeman Ltd',
        model: 'Model Z',
      },
      {
        id: 97,
        brand: 'Brown Group',
        model: 'Model Y',
      },
      {
        id: 54,
        brand: 'Young Group',
        model: 'Model Z',
      },
      {
        id: 53,
        brand: 'Edwards-Mueller',
        model: 'Model X',
      },
      {
        id: 68,
        brand: 'Crawford Ltd',
        model: 'Model Y',
      },
    ],
  },
  {
    id: 95,
    asset_type: 'house',
    status: 'rented',
    location: '040 Cody Fork\nKlineton, IN 76818',
    occupancy_history: [
      {
        id: 42,
        start_date: '1983-08-19',
        end_date: '2001-08-08',
        license_plate: 'N/A',
      },
      {
        id: 27,
        start_date: '1974-12-31',
        end_date: '1994-08-21',
        license_plate: 'N/A',
      },
      {
        id: 74,
        start_date: '2013-08-07',
        end_date: '1970-12-19',
        license_plate: 'N/A',
      },
      {
        id: 75,
        start_date: '2018-02-20',
        end_date: '2001-10-17',
        license_plate: 'N/A',
      },
      {
        id: 37,
        start_date: '2014-04-05',
        end_date: '1998-11-14',
        license_plate: 'N/A',
      },
      {
        id: 16,
        start_date: '1992-07-19',
        end_date: '1992-02-24',
        license_plate: 'N/A',
      },
      {
        id: 48,
        start_date: '2018-02-07',
        end_date: '1972-04-25',
        license_plate: 'N/A',
      },
      {
        id: 21,
        start_date: '2023-09-29',
        end_date: '1996-01-10',
        license_plate: 'N/A',
      },
      {
        id: 23,
        start_date: '2008-04-13',
        end_date: '2008-11-05',
        license_plate: 'N/A',
      },
      {
        id: 17,
        start_date: '2021-07-13',
        end_date: '2012-08-13',
        license_plate: 'N/A',
      },
    ],
    rent_history: [
      {
        id: 53,
        change_date: '1980-07-24',
        amount: 363.67,
      },
      {
        id: 22,
        change_date: '2017-02-22',
        amount: 885.83,
      },
      {
        id: 16,
        change_date: '1993-08-29',
        amount: 836.35,
      },
    ],
    damage_history: [
      {
        id: 84,
        description: 'Big home know industry debate. Free brother believe me question available.',
        date_reported: '1995-01-22',
      },
      {
        id: 59,
        description: 'Care almost onto democratic. Next while real American. Director teacher choose serious whole.',
        date_reported: '2021-07-06',
      },
      {
        id: 83,
        description: 'Method almost back mind. See begin today.',
        date_reported: '1996-12-02',
      },
      {
        id: 22,
        description: 'Plan yourself decide someone. Film others light natural.',
        date_reported: '1994-07-12',
      },
      {
        id: 20,
        description: 'Enjoy none firm.\nLine agree show white trip dream general. Wind between third.',
        date_reported: '1980-10-30',
      },
    ],
    appliances: [
      {
        id: 68,
        brand: 'Vasquez Inc',
        model: 'Model Z',
      },
      {
        id: 18,
        brand: 'Bautista, Stevens and Butler',
        model: 'Model X',
      },
      {
        id: 7,
        brand: 'Cook, Hamilton and Bowman',
        model: 'Model Z',
      },
      {
        id: 6,
        brand: 'Glover and Sons',
        model: 'Model Z',
      },
      {
        id: 88,
        brand: 'Gomez, Lopez and Hicks',
        model: 'Model Z',
      },
    ],
  },
  {
    id: 47,
    asset_type: 'house',
    status: 'damaged',
    location: '212 Michael Ports Suite 090\nWoodsmouth, HI 37038',
    occupancy_history: [
      {
        id: 28,
        start_date: '2017-07-11',
        end_date: '1999-03-25',
        license_plate: 'N/A',
      },
      {
        id: 59,
        start_date: '1974-01-02',
        end_date: '1972-07-30',
        license_plate: 'N/A',
      },
      {
        id: 67,
        start_date: '2005-12-16',
        end_date: '1991-10-12',
        license_plate: 'N/A',
      },
      {
        id: 73,
        start_date: '1979-05-21',
        end_date: '1997-11-03',
        license_plate: 'N/A',
      },
      {
        id: 43,
        start_date: '1995-08-19',
        end_date: '1979-04-20',
        license_plate: 'N/A',
      },
      {
        id: 84,
        start_date: '1978-12-13',
        end_date: '2009-03-08',
        license_plate: 'N/A',
      },
      {
        id: 24,
        start_date: '1998-10-23',
        end_date: '1997-05-17',
        license_plate: 'N/A',
      },
      {
        id: 59,
        start_date: '2004-04-16',
        end_date: '1988-10-18',
        license_plate: 'N/A',
      },
      {
        id: 2,
        start_date: '2020-08-08',
        end_date: '2001-01-14',
        license_plate: 'N/A',
      },
      {
        id: 26,
        start_date: '1993-08-29',
        end_date: '1983-07-09',
        license_plate: 'N/A',
      },
    ],
    rent_history: [
      {
        id: 48,
        change_date: '1985-07-13',
        amount: 1338.5,
      },
      {
        id: 8,
        change_date: '2023-07-20',
        amount: 907.67,
      },
      {
        id: 23,
        change_date: '1970-06-18',
        amount: 1793.88,
      },
    ],
    damage_history: [
      {
        id: 25,
        description: 'Pressure only dark pattern security color century. Boy admit prevent often.',
        date_reported: '2016-11-23',
      },
      {
        id: 34,
        description: 'Kitchen people nearly I building. Current collection institution late anything development if.',
        date_reported: '1973-04-18',
      },
      {
        id: 47,
        description: 'Much sell truth best experience thing let less. Listen agree listen follow.',
        date_reported: '2001-05-02',
      },
      {
        id: 71,
        description: 'Work morning bit way try time. Either company since none.',
        date_reported: '2004-11-23',
      },
      {
        id: 80,
        description: 'Back PM major probably type charge. Prepare include arrive policy decision specific.',
        date_reported: '1996-05-18',
      },
    ],
    appliances: [
      {
        id: 41,
        brand: 'Craig Inc',
        model: 'Model Y',
      },
      {
        id: 2,
        brand: 'Howell-Hall',
        model: 'Model Y',
      },
      {
        id: 67,
        brand: 'Perez, Gonzalez and Terrell',
        model: 'Model Z',
      },
      {
        id: 35,
        brand: 'Mills and Sons',
        model: 'Model Y',
      },
      {
        id: 47,
        brand: 'Walker Ltd',
        model: 'Model Y',
      },
    ],
  },
  {
    id: 93,
    asset_type: 'house',
    status: 'damaged',
    location: '3601 Hall Stream Suite 124\nJennatown, NM 86146',
    occupancy_history: [
      {
        id: 95,
        start_date: '1990-04-01',
        end_date: '1987-12-05',
        license_plate: 'N/A',
      },
      {
        id: 76,
        start_date: '2000-09-30',
        end_date: '1981-06-06',
        license_plate: 'N/A',
      },
      {
        id: 3,
        start_date: '2019-05-05',
        end_date: '1977-06-10',
        license_plate: 'N/A',
      },
      {
        id: 59,
        start_date: '1996-10-30',
        end_date: '1970-09-25',
        license_plate: 'N/A',
      },
      {
        id: 90,
        start_date: '2018-04-11',
        end_date: '1994-06-27',
        license_plate: 'N/A',
      },
      {
        id: 61,
        start_date: '1971-07-16',
        end_date: '2015-11-03',
        license_plate: 'N/A',
      },
      {
        id: 88,
        start_date: '1986-03-01',
        end_date: '2022-07-27',
        license_plate: 'N/A',
      },
      {
        id: 40,
        start_date: '1975-12-21',
        end_date: '1996-05-06',
        license_plate: 'N/A',
      },
      {
        id: 15,
        start_date: '2004-09-02',
        end_date: '1982-11-18',
        license_plate: 'N/A',
      },
      {
        id: 75,
        start_date: '1972-01-30',
        end_date: '1980-08-07',
        license_plate: 'N/A',
      },
    ],
    rent_history: [
      {
        id: 1,
        change_date: '1997-09-22',
        amount: 1107.24,
      },
      {
        id: 39,
        change_date: '2017-11-10',
        amount: 1032.43,
      },
      {
        id: 45,
        change_date: '1978-04-30',
        amount: 1196.64,
      },
    ],
    damage_history: [
      {
        id: 77,
        description: 'Push station one focus spend than. Sell risk full born window.',
        date_reported: '2017-12-02',
      },
      {
        id: 89,
        description: 'Heavy lot just race visit three. Rate artist guess.',
        date_reported: '1994-11-04',
      },
      {
        id: 2,
        description: 'Increase return create usually ahead. Kind day occur however buy run.',
        date_reported: '2003-06-20',
      },
      {
        id: 98,
        description: 'Structure upon board why personal. Central cold raise difference part collection expert.',
        date_reported: '2007-09-23',
      },
      {
        id: 53,
        description: 'Chance security professor commercial. Crime occur how person record police business.',
        date_reported: '1997-08-16',
      },
    ],
    appliances: [
      {
        id: 26,
        brand: 'Morris, Martin and Kelley',
        model: 'Model Z',
      },
      {
        id: 40,
        brand: 'Nicholson, Johnson and Martinez',
        model: 'Model Z',
      },
      {
        id: 19,
        brand: 'Johnson-Higgins',
        model: 'Model Z',
      },
      {
        id: 33,
        brand: 'Peters-Anderson',
        model: 'Model Y',
      },
      {
        id: 83,
        brand: 'Obrien, Trevino and Guerrero',
        model: 'Model Z',
      },
    ],
  },
  {
    id: 78,
    asset_type: 'parking-spot',
    status: 'damaged',
    location: '34860 Kaitlin Mall\nPort Brettmouth, MT 81261',
    occupancy_history: [
      {
        id: 75,
        start_date: '2003-04-07',
        end_date: '2021-02-13',
        license_plate: '51U 5544',
      },
      {
        id: 27,
        start_date: '2023-06-28',
        end_date: '1971-09-12',
        license_plate: '55-IG46',
      },
      {
        id: 62,
        start_date: '2002-01-27',
        end_date: '1974-09-30',
        license_plate: '325 CEW',
      },
      {
        id: 37,
        start_date: '1985-04-23',
        end_date: '2019-05-25',
        license_plate: '42Q G26',
      },
      {
        id: 41,
        start_date: '1992-08-27',
        end_date: '1974-09-05',
        license_plate: '506BI',
      },
      {
        id: 59,
        start_date: '2006-11-18',
        end_date: '1986-04-28',
        license_plate: 'CIW-5243',
      },
      {
        id: 16,
        start_date: '1987-06-22',
        end_date: '1987-03-18',
        license_plate: '099 9375',
      },
      {
        id: 14,
        start_date: '1985-11-23',
        end_date: '1996-05-09',
        license_plate: '2B 3931X',
      },
      {
        id: 6,
        start_date: '2001-01-03',
        end_date: '1981-02-23',
        license_plate: 'GES-055',
      },
      {
        id: 28,
        start_date: '1989-10-21',
        end_date: '2015-02-16',
        license_plate: '7Q459',
      },
    ],
    rent_history: [
      {
        id: 89,
        change_date: '1979-11-03',
        amount: 481.17,
      },
      {
        id: 83,
        change_date: '2017-12-25',
        amount: 903.09,
      },
      {
        id: 21,
        change_date: '2010-11-11',
        amount: 895.98,
      },
    ],
    damage_history: [
      {
        id: 85,
        description: 'Partner available speak military voice.',
        date_reported: '2010-03-18',
      },
      {
        id: 53,
        description: 'Figure sometimes arm career high church might. Activity film oil paper small.',
        date_reported: '2013-08-07',
      },
      {
        id: 51,
        description: 'Court space beautiful hear tax team for. Reflect then when itself away important.',
        date_reported: '2023-11-01',
      },
      {
        id: 49,
        description: 'City Congress popular student policy hundred tax.',
        date_reported: '1984-07-15',
      },
      {
        id: 84,
        description: 'Rock character particular bar real out huge. Hand break set. Word much by.',
        date_reported: '1981-06-28',
      },
    ],
    appliances: [
      {
        id: 36,
        brand: 'Newman-Randall',
        model: 'Model Y',
      },
      {
        id: 50,
        brand: 'Peterson and Sons',
        model: 'Model X',
      },
      {
        id: 73,
        brand: 'Henderson Ltd',
        model: 'Model X',
      },
      {
        id: 89,
        brand: 'Mitchell-Willis',
        model: 'Model Y',
      },
      {
        id: 18,
        brand: 'Carson, Reed and Salas',
        model: 'Model Z',
      },
    ],
  },
  {
    id: 2,
    asset_type: 'apartment',
    status: 'rented',
    location: '062 Schneider Summit Apt. 566\nChapmanborough, GA 62983',
    occupancy_history: [
      {
        id: 64,
        start_date: '1992-09-27',
        end_date: '1993-06-13',
        license_plate: 'N/A',
      },
      {
        id: 30,
        start_date: '2009-12-11',
        end_date: '1992-12-15',
        license_plate: 'N/A',
      },
      {
        id: 56,
        start_date: '2007-11-05',
        end_date: '1978-09-12',
        license_plate: 'N/A',
      },
      {
        id: 59,
        start_date: '1993-03-23',
        end_date: '2012-04-21',
        license_plate: 'N/A',
      },
      {
        id: 57,
        start_date: '1988-09-11',
        end_date: '1990-08-01',
        license_plate: 'N/A',
      },
      {
        id: 81,
        start_date: '1977-09-05',
        end_date: '2011-05-30',
        license_plate: 'N/A',
      },
      {
        id: 37,
        start_date: '1986-03-16',
        end_date: '1990-03-21',
        license_plate: 'N/A',
      },
      {
        id: 16,
        start_date: '1985-12-25',
        end_date: '2007-10-24',
        license_plate: 'N/A',
      },
      {
        id: 62,
        start_date: '2016-07-23',
        end_date: '2018-04-26',
        license_plate: 'N/A',
      },
      {
        id: 83,
        start_date: '1999-07-13',
        end_date: '1981-12-15',
        license_plate: 'N/A',
      },
    ],
    rent_history: [
      {
        id: 24,
        change_date: '1978-10-02',
        amount: 475.76,
      },
      {
        id: 60,
        change_date: '1995-01-24',
        amount: 816.27,
      },
      {
        id: 11,
        change_date: '1997-08-01',
        amount: 820.29,
      },
    ],
    damage_history: [
      {
        id: 48,
        description: 'Citizen project win do war. Trip too concern mean establish Republican talk possible.',
        date_reported: '1978-02-06',
      },
      {
        id: 35,
        description: 'Party remember official. Which anyone specific difference. Service college land machine.',
        date_reported: '1984-07-20',
      },
      {
        id: 34,
        description: 'Across ability a it subject lay central our.',
        date_reported: '1992-06-13',
      },
      {
        id: 17,
        description: 'They popular do. Especially rest until answer line first.',
        date_reported: '2003-08-19',
      },
      {
        id: 52,
        description: 'Late make generation growth pretty. Its four material coach fact.',
        date_reported: '2001-12-17',
      },
    ],
    appliances: [
      {
        id: 30,
        brand: 'Smith Inc',
        model: 'Model Y',
      },
      {
        id: 49,
        brand: 'Ferguson Inc',
        model: 'Model Z',
      },
      {
        id: 60,
        brand: 'Kline, Thompson and Robinson',
        model: 'Model X',
      },
      {
        id: 94,
        brand: 'Green and Sons',
        model: 'Model Y',
      },
      {
        id: 58,
        brand: 'Green-Coleman',
        model: 'Model Y',
      },
    ],
  },
  {
    id: 32,
    asset_type: 'parking-spot',
    status: 'rented',
    location: '66109 Manuel Neck\nPort Debratown, SC 04897',
    occupancy_history: [
      {
        id: 4,
        start_date: '1978-09-30',
        end_date: '2016-05-13',
        license_plate: '1R 25976',
      },
      {
        id: 89,
        start_date: '1997-09-21',
        end_date: '1991-07-14',
        license_plate: '79L\u2022423',
      },
      {
        id: 79,
        start_date: '2023-06-08',
        end_date: '1972-01-04',
        license_plate: '265 AHZ',
      },
      {
        id: 25,
        start_date: '2008-04-04',
        end_date: '1999-09-07',
        license_plate: 'QE 79080',
      },
      {
        id: 27,
        start_date: '1985-10-15',
        end_date: '2021-07-19',
        license_plate: '0-9504J',
      },
      {
        id: 12,
        start_date: '2020-03-18',
        end_date: '2000-02-21',
        license_plate: 'T10 1DP',
      },
      {
        id: 30,
        start_date: '1988-04-24',
        end_date: '2001-11-26',
        license_plate: '1YR 036',
      },
      {
        id: 87,
        start_date: '2010-12-03',
        end_date: '1986-02-04',
        license_plate: 'XYT X33',
      },
      {
        id: 8,
        start_date: '2003-06-18',
        end_date: '2000-08-21',
        license_plate: 'CIP 383',
      },
      {
        id: 73,
        start_date: '1971-07-12',
        end_date: '1996-12-20',
        license_plate: '289I4',
      },
    ],
    rent_history: [
      {
        id: 22,
        change_date: '2017-05-06',
        amount: 373.12,
      },
      {
        id: 78,
        change_date: '1997-09-28',
        amount: 463.83,
      },
      {
        id: 19,
        change_date: '1990-06-27',
        amount: 1189.92,
      },
    ],
    damage_history: [
      {
        id: 65,
        description: 'Agree low how. With various push here describe situation star image.',
        date_reported: '2020-07-11',
      },
      {
        id: 19,
        description: 'Cup our ball energy. Especially ok stock idea image free. Member want difficult little.',
        date_reported: '1981-12-03',
      },
      {
        id: 66,
        description: 'Stay matter cut management.',
        date_reported: '2002-07-25',
      },
      {
        id: 9,
        description: 'Yet show ability big fine. Relationship door too section stand arrive approach.',
        date_reported: '1972-08-12',
      },
      {
        id: 8,
        description: 'Window same option start outside letter. Benefit pressure front result. Rest sport material.',
        date_reported: '1997-11-28',
      },
    ],
    appliances: [
      {
        id: 23,
        brand: 'Koch, Hoffman and Patel',
        model: 'Model X',
      },
      {
        id: 94,
        brand: 'Hall Group',
        model: 'Model X',
      },
      {
        id: 8,
        brand: 'Bautista Inc',
        model: 'Model X',
      },
      {
        id: 9,
        brand: 'Aguilar PLC',
        model: 'Model Y',
      },
      {
        id: 84,
        brand: 'Martin LLC',
        model: 'Model X',
      },
    ],
  },
  {
    id: 28,
    asset_type: 'parking-spot',
    status: 'damaged',
    location: '60433 Angelica Junction Suite 188\nSusanmouth, SC 15350',
    occupancy_history: [
      {
        id: 21,
        start_date: '1990-01-24',
        end_date: '2010-02-14',
        license_plate: 'PFA 578',
      },
      {
        id: 83,
        start_date: '1985-09-26',
        end_date: '1993-03-11',
        license_plate: '43W UI5',
      },
      {
        id: 89,
        start_date: '1999-03-22',
        end_date: '2016-12-15',
        license_plate: '29-KC50',
      },
      {
        id: 64,
        start_date: '1994-04-28',
        end_date: '1995-04-11',
        license_plate: '660-OLR',
      },
      {
        id: 69,
        start_date: '1990-07-21',
        end_date: '2003-12-13',
        license_plate: '8HU 306',
      },
      {
        id: 7,
        start_date: '1994-05-05',
        end_date: '2001-05-29',
        license_plate: '801988',
      },
      {
        id: 40,
        start_date: '2002-04-18',
        end_date: '1981-04-29',
        license_plate: '070 VXM',
      },
      {
        id: 15,
        start_date: '2001-11-02',
        end_date: '2016-09-20',
        license_plate: '74LT170',
      },
      {
        id: 51,
        start_date: '2011-12-17',
        end_date: '1976-08-02',
        license_plate: 'QXU-9402',
      },
      {
        id: 90,
        start_date: '2021-11-17',
        end_date: '1993-02-23',
        license_plate: '9-79324L',
      },
    ],
    rent_history: [
      {
        id: 6,
        change_date: '1999-09-26',
        amount: 1368.4,
      },
      {
        id: 3,
        change_date: '2013-04-08',
        amount: 706.46,
      },
      {
        id: 63,
        change_date: '1976-10-18',
        amount: 1296.52,
      },
    ],
    damage_history: [
      {
        id: 72,
        description: 'Left feeling evidence green sea water career. Course indeed quickly actually.',
        date_reported: '1992-09-22',
      },
      {
        id: 17,
        description:
          'Other within factor treat stay walk. Help anything management not. Share hundred prepare manager.',
        date_reported: '2018-04-24',
      },
      {
        id: 27,
        description: 'System by while can. Game stuff performance fact. Money western meeting agreement west.',
        date_reported: '1970-02-28',
      },
      {
        id: 82,
        description: 'Avoid wish resource security lawyer return foot Republican.',
        date_reported: '2019-03-31',
      },
      {
        id: 71,
        description: 'Author thus sea staff near. Later that put happen child.',
        date_reported: '1999-02-11',
      },
    ],
    appliances: [
      {
        id: 54,
        brand: 'Salazar and Sons',
        model: 'Model Z',
      },
      {
        id: 93,
        brand: 'Howard, Watson and Munoz',
        model: 'Model X',
      },
      {
        id: 3,
        brand: 'Phillips-Gentry',
        model: 'Model Y',
      },
      {
        id: 89,
        brand: 'Estrada-Lynch',
        model: 'Model X',
      },
      {
        id: 96,
        brand: 'Anderson-Fletcher',
        model: 'Model Y',
      },
    ],
  },
];

// Get the canvas element from the HTML file
const canvas = document.getElementById('myChart');

// Create the chart
const chart = new Chart(canvas, {
  type: 'line',
  data: {
    datasets: [
      {
        label: 'The number of rented-out properties by month',
        data: [],
        borderColor: 'blue',
        fill: false,
      },
    ],
  },
  options: {
    layout: {
      padding: 20,
    },
    responsive: true,
    scales: {
      y: {
        beginAtZero: true,
      },
    },
  },
});

// make a get request for the data
function getData() {
  // fetch('http://localhost:3000/api/rentals')
  //   .then((response) => response.json())
  //   .then((data) => {
  //     console.log(data);
  //     const labels = data.map((item) => item.month);
  //     const dataValues = data.map((item) => item.count);
  //     chart.data.labels = labels;
  //     chart.data.datasets[0].data = dataValues;
  //     chart.update();
  //   });

  const m = aggregateMonth();
  const labels = Object.keys(m).map((e) => Intl.DateTimeFormat('en-US', { month: 'short' }).format(new Date(2021, e)));
  const dataValues = Object.values(m);
  chart.data.labels = labels;
  chart.data.datasets[0].data = dataValues;
  chart.update();
}

function generateReport() {
  const { jsPDF } = window.jspdf;
  const doc = new jsPDF();
  // generate a pdf with a table
  doc.autoTable({
    head: [['ID', 'Asset Type', 'Status', 'Location']],
    body: data.map((item) => [item.id, item.asset_type, item.status, item.location]),
  });
  doc.output('dataurlnewwindow', 'report.pdf');
}

function aggregateMonth() {
  const m = {};
  data.map((item) =>
    item.occupancy_history.forEach((item) => {
      const d = item.start_date;
      if (m[new Date(Date.parse(d)).getMonth()]) {
        m[new Date(Date.parse(d)).getMonth()] += 1;
      } else {
        m[new Date(Date.parse(d)).getMonth()] = 1;
      }
    })
  );

  return m;
}