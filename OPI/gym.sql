PGDMP                          z            GYM    14.1    14.1     ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    16394    GYM    DATABASE     b   CREATE DATABASE "GYM" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "GYM";
                postgres    false            ?            1259    16559    coach    TABLE     ?   CREATE TABLE public.coach (
    coach_id integer NOT NULL,
    name_coach character varying(50) NOT NULL,
    phone_coach character varying(15) NOT NULL
);
    DROP TABLE public.coach;
       public         heap    postgres    false            ?            1259    16562    coach_coach_id_seq    SEQUENCE     ?   ALTER TABLE public.coach ALTER COLUMN coach_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.coach_coach_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    209            ?            1259    16563    students    TABLE     ?   CREATE TABLE public.students (
    students_id integer NOT NULL,
    name_students character varying(50) NOT NULL,
    phone_students character varying(15) NOT NULL,
    fk_students_coach integer
);
    DROP TABLE public.students;
       public         heap    postgres    false            ?            1259    16566    students_students_id_seq    SEQUENCE     ?   ALTER TABLE public.students ALTER COLUMN students_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.students_students_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    211            ?          0    16559    coach 
   TABLE DATA           B   COPY public.coach (coach_id, name_coach, phone_coach) FROM stdin;
    public          postgres    false    209          ?          0    16563    students 
   TABLE DATA           a   COPY public.students (students_id, name_students, phone_students, fk_students_coach) FROM stdin;
    public          postgres    false    211   w       ?           0    0    coach_coach_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.coach_coach_id_seq', 6, true);
          public          postgres    false    210            ?           0    0    students_students_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.students_students_id_seq', 17, true);
          public          postgres    false    212            b           2606    16568    coach coach_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.coach
    ADD CONSTRAINT coach_pkey PRIMARY KEY (coach_id);
 :   ALTER TABLE ONLY public.coach DROP CONSTRAINT coach_pkey;
       public            postgres    false    209            d           2606    16570    students students_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_pkey PRIMARY KEY (students_id);
 @   ALTER TABLE ONLY public.students DROP CONSTRAINT students_pkey;
       public            postgres    false    211            e           2606    16571 (   students students_fk_students_coach_fkey    FK CONSTRAINT     ?   ALTER TABLE ONLY public.students
    ADD CONSTRAINT students_fk_students_coach_fkey FOREIGN KEY (fk_students_coach) REFERENCES public.coach(coach_id);
 R   ALTER TABLE ONLY public.students DROP CONSTRAINT students_fk_students_coach_fkey;
       public          postgres    false    3170    211    209            ?   S   x?3??0??֋M?9???M?,!?ˈ?º?6@?? ?˘?{/6]?wa/T??L8/L???[?&????? ??#      ?   n   x?U???@??V,!???{q16!@@/!$?r{q"?d?ٙ>??Ά??^&3sw????X??/?Q_?xp?G/W????k?z?PEG???O,?{?=??ED~2?8?     