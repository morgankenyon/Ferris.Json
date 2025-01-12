## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.FerrisListMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rcx,1DA5AC041A8
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+58]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD33FC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+68],0
       je        near ptr M00_L11
       cmp       dword ptr [rsp+68],1
       jne       short M00_L00
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+60]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L00:
       mov       ebp,[rsp+68]
       test      ebp,ebp
       jl        near ptr M00_L12
       mov       rdi,[rsp+58]
       test      rdi,rdi
       je        near ptr M00_L13
       cmp       [rdi+8],ebp
       je        short M00_L02
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L04
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsp+58],r14
M00_L02:
       mov       ecx,[rsp+68]
       mov       [rsp+6C],ecx
       mov       rdi,[rsp+58]
M00_L03:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFD34484030]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       test      rax,rax
       jne       short M00_L05
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFD34125BD8]
       jmp       short M00_L01
M00_L05:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
M00_L06:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       mov       rdx,1DA00208830
       lea       r8,[rsp+30]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD34484108]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M00_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L14
       mov       rax,[rcx]
       add       rax,10
M00_L07:
       mov       r8,[rax+8]
       test      r8,r8
       jne       short M00_L08
       mov       r8,1DA5AC00438
       mov       r8,[r8]
       test      r8,r8
       jne       short M00_L08
       mov       r8,1DA5AC00418
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M00_L15
M00_L08:
       mov       rcx,[rsp+40]
       mov       rdx,1DA00208830
       call      qword ptr [7FFD344846D8]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       r8,rax
       test      r8,r8
       je        short M00_L09
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.MixedListTestObj
       cmp       [r8],rcx
       je        short M00_L09
       mov       rdx,rax
       call      qword ptr [7FFD340743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L09:
       mov       rcx,1DA5AC041A8
       mov       rcx,[rcx]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+10]
       mov       rdx,[r8+8]
       cmp       ecx,[rdx+10]
       jne       short M00_L10
       inc       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L10:
       dec       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L11:
       mov       rcx,1DA5AC01F30
       mov       rdi,[rcx]
       jmp       near ptr M00_L03
M00_L12:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD3420ED48]
       int       3
M00_L13:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+58],rax
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L07
M00_L15:
       call      qword ptr [7FFD341B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r8,rax
       jmp       near ptr M00_L08
; Total bytes of code 647
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rbx,rbx
       je        near ptr M01_L03
       test      dil,1
       je        short M01_L00
       mov       rdx,rbx
       mov       rcx,1DA5AC00590
       mov       rcx,[rcx]
       call      qword ptr [7FFD345A4C18]
       mov       rbx,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rbx+8]
       mov       eax,ecx
       cmp       word ptr [rbx+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rbx
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L22
       test      r15d,r15d
       je        near ptr M01_L10
       cmp       ecx,r15d
       je        near ptr M01_L09
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,r15d
       cmp       [rbx],bl
       lea       rcx,[rbx+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFD34125B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L11
       mov       rbp,rax
M01_L05:
       mov       [rsp+38],rbx
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L07
       mov       rax,[rsp+38]
M01_L06:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L12
       cmp       r12d,2
       je        near ptr M01_L14
       jmp       near ptr M01_L16
M01_L07:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFD34266838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L17
M01_L09:
       mov       rbx,r12
       jmp       near ptr M01_L02
M01_L10:
       mov       rbx,1DA00200008
       jmp       near ptr M01_L02
M01_L11:
       mov       rcx,rbp
       call      qword ptr [7FFD33FC6658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L05
M01_L12:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD34265050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L13
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFD34266838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L13:
       mov       r12,rax
       jmp       short M01_L17
M01_L14:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD34265050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L15
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFD34266838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L15:
       jmp       short M01_L17
M01_L16:
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L08
       mov       r12,[rbp+8]
M01_L17:
       xor       edi,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L21
M01_L18:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,edi
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M01_L20
       test      r15d,r15d
       jne       short M01_L23
       test      r14,r14
       jne       near ptr M01_L24
M01_L19:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD34264FA8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L20:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L18
M01_L21:
       mov       rdx,[rsp+50]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rsi+10],eax
       mov       eax,[rsp+64]
       mov       [rsi+14],eax
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFD34077258]
       int       3
M01_L23:
       mov       rcx,r10
       mov       rdx,rbx
       mov       r8d,r13d
       call      qword ptr [7FFD33FC6538]
       test      eax,eax
       je        short M01_L20
       mov       r10,[rsp+40]
       test      r14,r14
       je        near ptr M01_L19
M01_L24:
       mov       rcx,r10
       call      qword ptr [7FFD3431D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L20
       mov       r10,[rsp+40]
       jmp       near ptr M01_L19
; Total bytes of code 841
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1E8
       vzeroupper
       lea       rbp,[rsp+220]
       xor       eax,eax
       mov       [rbp-158],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M02_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp-40],rax
       mov       [rbp-1F0],rsp
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L100
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       r14d,r14d
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L24
M02_L03:
       mov       ecx,r14d
       mov       r15,[rsi+rcx*8+10]
       mov       r13,[r15]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L102
       mov       rcx,r15
       cmp       qword ptr [rcx+18],0
       je        near ptr M02_L101
       mov       rcx,[r15+18]
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L94
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD34253270]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
M02_L05:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L93
       mov       rcx,r15
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L92
M02_L06:
       mov       rcx,[r15+38]
       mov       rax,[rcx+18]
M02_L07:
       mov       rdx,rax
       mov       [rbp-168],rdx
       test      r12,r12
       je        near ptr M02_L90
       mov       rcx,1DA00200020
       cmp       rdx,rcx
       jne       near ptr M02_L33
M02_L08:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1DA5AC01EE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFD34249EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M02_L110
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M02_L09:
       mov       [rbp-48],r8
       mov       [rbp-40],eax
       xor       edx,edx
       mov       [rbp-50],edx
       mov       byte ptr [rbp-4C],0
       mov       edx,[rbp-50]
       cmp       edx,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L111
       mov       rdx,1DA00208864
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-50]
       inc       edx
       mov       [rbp-50],edx
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rdx
       jne       near ptr M02_L112
M02_L10:
       mov       r13,[r15+8]
       test      r13,r13
       je        near ptr M02_L28
M02_L11:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L113
M02_L12:
       test      r13,r13
       je        near ptr M02_L113
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M02_L113
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFD34125B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rbp-50]
       add       edx,[r13+8]
       mov       [rbp-50],edx
M02_L13:
       mov       edx,[rbp-50]
       cmp       edx,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L114
       mov       rdx,1DA002088CC
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rbp-50]
       add       edx,3
       mov       [rbp-50],edx
M02_L14:
       mov       [rbp-0D0],r12
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L27
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD34074348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L26
       xor       r8d,r8d
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D0]
       cmp       qword ptr [rbp-0D8],0
       jne       short M02_L15
       mov       r8,[r8]
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D8]
       cmp       qword ptr [rbp-0D8],0
       je        near ptr M02_L103
M02_L15:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L104
M02_L16:
       mov       r15,rcx
M02_L17:
       test      r15,r15
       je        short M02_L18
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L105
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD34125B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[r15+8]
       mov       [rbp-50],ecx
M02_L18:
       xor       ecx,ecx
       mov       [rbp-0D8],rcx
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L117
       mov       rcx,1DA00208864
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M02_L19:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rax,[rbp-48]
       mov       [rbp-158],rax
       mov       [rbp-150],ecx
       lea       rcx,[rbp-158]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r15,[rbp-58]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       test      r15,r15
       je        near ptr M02_L22
       mov       rcx,1DA5AC01EE8
       mov       r12,[rcx]
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-0E4],eax
       mov       rcx,7FFD33FB5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L106
M02_L20:
       xor       eax,eax
       mov       dword ptr [rbp-0EC],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-0E4]
       cmp       edx,r10d
       jbe       near ptr M02_L21
       mov       dword ptr [rbp-0E8],1
       mov       edx,10
       shlx      edx,edx,r10d
       cmp       [r15+8],edx
       jne       near ptr M02_L95
       mov       [rbp-0E4],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rbp-1A0],r9
       mov       r11,[r9]
       mov       [rbp-1A8],r11
       mov       rcx,r9
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-1A0]
       mov       [rdx+8],ecx
       mov       rax,[rbp-1A8]
       test      rax,rax
       mov       [rbp-1A8],rax
       mov       eax,[rbp-0E8]
       mov       r10d,[rbp-0E4]
       jne       near ptr M02_L107
M02_L21:
       mov       rcx,1DA5AC005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M02_L130
M02_L22:
       mov       rdx,r13
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L29
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L23:
       inc       r14d
       cmp       [rsi+8],r14d
       jg        near ptr M02_L03
M02_L24:
       mov       rdx,rdi
       mov       rcx,1DA00200C60
       call      qword ptr [7FFD34076DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       r13,rax
       test      r13,r13
       je        near ptr M02_L98
       cmp       dword ptr [r13+8],0
       je        near ptr M02_L98
       mov       ecx,[r13+8]
       add       rcx,2
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L99
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       [rbx],bl
       lea       r8,[rbx+0C]
       mov       rcx,1DA00208AEC
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[rbx+0E]
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFD34125B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[r13+8]
       inc       eax
       cdqe
       lea       rax,[rbx+rax*2+0C]
       mov       rcx,1DA00208B04
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       rax,rbx
M02_L25:
       add       rsp,1E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L26:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD34074348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L116
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD340743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rbp-60]
       mov       r11,7FFD33F30700
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L17
M02_L27:
       lea       rcx,[rbp-60]
       mov       r8,[rbp-0D0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD345ACD80]
       jmp       near ptr M02_L18
M02_L28:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0B8],xmm0
       mov       rdx,[r15+48]
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFD34266B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0B8]
       vmovups   [rbp-0C8],xmm0
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFD34266BE0]; System.MdUtf8String.ToString()
       mov       r13,rax
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L11
M02_L29:
       mov       rcx,rdi
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L30:
       test      rcx,rcx
       je        near ptr M02_L96
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD34253270]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M02_L31:
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFD34074348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L89
       mov       rcx,offset MT_System.Collections.Generic.List`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rcx
       jne       near ptr M02_L137
       mov       rcx,rax
       call      qword ptr [7FFD341364F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M02_L32:
       mov       [rbp-170],rax
       jmp       near ptr M02_L43
M02_L33:
       mov       rcx,1DA00208898
       cmp       rdx,rcx
       je        near ptr M02_L08
       mov       rcx,1DA002088E0
       call      qword ptr [7FFD33FBA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M02_L146
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1DA5AC01F00
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L136
       mov       rcx,r15
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L135
       jmp       near ptr M02_L30
M02_L34:
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L35:
       mov       [rbp-48],rdx
       mov       [rbp-40],eax
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L140
       mov       rcx,1DA00208864
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       jne       near ptr M02_L141
M02_L36:
       mov       rcx,r15
       call      qword ptr [7FFD3431D050]; System.Reflection.RuntimePropertyInfo.get_Name()
       mov       r13,rax
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L142
M02_L37:
       test      r13,r13
       je        near ptr M02_L142
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M02_L142
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFD34125B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-50]
       add       r8d,[r13+8]
       mov       [rbp-50],r8d
M02_L38:
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       edx,3
       jb        near ptr M02_L143
       mov       r8,1DA00208914
       mov       eax,[r8]
       mov       edx,[r8+2]
       mov       [rcx],eax
       mov       [rcx+2],edx
       mov       r8d,[rbp-50]
       add       r8d,3
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M02_L144
M02_L39:
       test      r12,r12
       je        near ptr M02_L144
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M02_L97
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M02_L144
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD34125B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[r12+8]
       mov       [rbp-50],ecx
M02_L40:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L145
       mov       rcx,1DA00208934
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M02_L41:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L42
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L42:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L43:
       cmp       qword ptr [rbp-170],0
       je        near ptr M02_L84
       mov       rcx,[rbp-170]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rcx],rdx
       jne       near ptr M02_L84
       jmp       near ptr M02_L71
M02_L44:
       mov       rdx,[rbp-170]
       add       rdx,8
       mov       ecx,[rdx+10]
       test      ecx,ecx
       je        near ptr M02_L48
       mov       rax,[rdx]
       mov       eax,[rax+10]
       inc       eax
       cmp       ecx,eax
       je        near ptr M02_L48
       mov       rax,[rdx+8]
       mov       r8,rax
       mov       [rbp-178],r8
       mov       rcx,r8
       call      System.Object.GetType()
       mov       rcx,rax
       mov       [rbp-1E0],rcx
       mov       rax,rcx
       mov       rdx,1DA00200020
       cmp       rax,rdx
       je        near ptr M02_L46
       mov       rdx,1DA00208898
       cmp       rax,rdx
       je        near ptr M02_L46
       mov       rcx,rax
       call      qword ptr [7FFD33FC7330]; System.RuntimeType.GetBaseType()
       mov       rdx,1DA002021B8
       cmp       rax,rdx
       jne       near ptr M02_L54
       mov       rcx,[rbp-1E0]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-128]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD33FC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-118],0
       je        short M02_L45
       cmp       dword ptr [rbp-118],1
       jne       near ptr M02_L62
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,rax
       mov       [rbp-1C0],rcx
       mov       r8,[rbp-120]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-1C0]
       jmp       near ptr M02_L66
M02_L45:
       mov       rdx,1DA5AC01F30
       mov       rcx,[rdx]
       jmp       near ptr M02_L66
M02_L46:
       mov       rcx,[rbp-178]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,1DA00208858
       mov       r8,1DA00208858
       call      qword ptr [7FFD34076B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       short M02_L47
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L71
M02_L47:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L71
M02_L48:
       call      qword ptr [7FFD3420F000]
       int       3
M02_L49:
       mov       rcx,[rbp-178]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       near ptr M02_L58
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L84
M02_L50:
       movsxd    rdx,r9d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-128],rax
       jmp       near ptr M02_L78
M02_L51:
       mov       rdx,1DA5AC01F30
       mov       rcx,[rdx]
       jmp       near ptr M02_L79
M02_L52:
       mov       rcx,[rbp-178]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,1DA00208858
       mov       r8,1DA00208858
       call      qword ptr [7FFD34076B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       near ptr M02_L57
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L84
M02_L53:
       mov       rcx,[rbp-170]
       mov       r11,7FFD33F306F0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M02_L74
M02_L54:
       mov       rcx,[rbp-178]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       cmp       [r8+8],r10d
       jbe       short M02_L56
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L71
M02_L55:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-128],rax
       jmp       near ptr M02_L65
M02_L56:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L71
M02_L57:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L84
M02_L58:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L84
M02_L59:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD3420ED48]
       int       3
M02_L60:
       call      qword ptr [7FFD3420EFE8]
       int       3
M02_L61:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L62:
       mov       eax,[rbp-118]
       test      eax,eax
       jl        short M02_L59
       mov       r8,[rbp-128]
       mov       rdx,r8
       test      rdx,rdx
       je        near ptr M02_L55
       mov       [rbp-1C8],rdx
       cmp       [rdx+8],eax
       je        short M02_L65
       mov       [rbp-12C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-1D0],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-1C8]
       lea       r10,[rdx+10]
       mov       r9d,[rdx+8]
       mov       r11d,[rbp-12C]
       cmp       r11d,r9d
       jg        near ptr M02_L67
       mov       r9d,r11d
M02_L63:
       mov       r8d,r9d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L87
       mov       rdx,r10
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L64:
       mov       rax,[rbp-1D0]
       mov       [rbp-128],rax
M02_L65:
       mov       ecx,[rbp-118]
       mov       [rbp-114],ecx
       mov       rcx,[rbp-128]
M02_L66:
       mov       rdx,[rbp-178]
       call      qword ptr [7FFD34484030]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       mov       ecx,[r8+8]
       cmp       ecx,r10d
       jbe       short M02_L70
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L71
M02_L67:
       jmp       short M02_L63
M02_L68:
       mov       ecx,[rax+14]
       mov       r11,[rax]
       cmp       ecx,[r11+14]
       jne       near ptr M02_L60
M02_L69:
       mov       rcx,[rax]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+8],rcx
       jmp       near ptr M02_L88
M02_L70:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L71:
       mov       rax,[rbp-170]
       add       rax,8
       mov       r8,[rax]
       mov       ecx,[rax+14]
       cmp       ecx,[r8+14]
       jne       short M02_L68
       mov       ecx,[rax+10]
       cmp       ecx,[r8+10]
       jae       short M02_L69
       lea       rcx,[rax+8]
       mov       r10,[r8+8]
       mov       [rbp-1D8],rax
       mov       r9d,[rax+10]
       cmp       r9d,[r10+8]
       jae       near ptr M02_L61
       mov       edx,r9d
       mov       rdx,[r10+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-1D8]
       inc       dword ptr [rax+10]
       jmp       near ptr M02_L44
M02_L72:
       mov       rcx,[rbp-170]
       mov       r11,7FFD33F306E8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L53
       jmp       near ptr M02_L88
M02_L73:
       mov       rdx,[rbp-170]
       add       rdx,8
       mov       ecx,[rdx+10]
       test      ecx,ecx
       je        near ptr M02_L48
       mov       rax,[rdx]
       mov       eax,[rax+10]
       inc       eax
       cmp       ecx,eax
       je        near ptr M02_L48
       mov       rax,[rdx+8]
       mov       rdx,rax
M02_L74:
       mov       rax,rdx
       mov       [rbp-178],rax
       mov       rcx,rax
       call      System.Object.GetType()
       mov       rcx,rax
       mov       [rbp-1E8],rcx
       mov       rax,rcx
       mov       rdx,1DA00200020
       cmp       rax,rdx
       je        near ptr M02_L52
       mov       rdx,1DA00208898
       cmp       rax,rdx
       je        near ptr M02_L52
       mov       rcx,rax
       call      qword ptr [7FFD33FC7330]; System.RuntimeType.GetBaseType()
       mov       rdx,1DA002021B8
       cmp       rax,rdx
       jne       near ptr M02_L49
       mov       rcx,[rbp-1E8]
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-128]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD33FC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-118],0
       je        near ptr M02_L51
       cmp       dword ptr [rbp-118],1
       jne       short M02_L75
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,rax
       mov       [rbp-1C0],rcx
       mov       r8,[rbp-120]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rbp-1C0]
       jmp       near ptr M02_L79
M02_L75:
       mov       r11d,[rbp-118]
       mov       r9d,r11d
       test      r9d,r9d
       jl        near ptr M02_L59
       mov       rdx,[rbp-128]
       test      rdx,rdx
       je        near ptr M02_L50
       mov       [rbp-1C8],rdx
       mov       eax,[rdx+8]
       mov       [rbp-15C],eax
       cmp       eax,r9d
       je        short M02_L78
       mov       [rbp-12C],r9d
       movsxd    rdx,r9d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-1D0],rax
       lea       rcx,[rax+10]
       mov       rdx,[rbp-1C8]
       add       rdx,10
       mov       r9d,[rbp-15C]
       mov       r10d,[rbp-12C]
       cmp       r10d,r9d
       jg        near ptr M02_L80
       mov       r9d,r10d
M02_L76:
       mov       r8d,r9d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L83
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L77:
       mov       rcx,[rbp-1D0]
       mov       [rbp-128],rcx
M02_L78:
       mov       ecx,[rbp-118]
       mov       [rbp-114],ecx
       mov       rcx,[rbp-128]
M02_L79:
       mov       rdx,[rbp-178]
       call      qword ptr [7FFD34484030]
       inc       dword ptr [r12+14]
       mov       r8,[r12+8]
       mov       r10d,[r12+10]
       mov       ecx,[r8+8]
       cmp       ecx,r10d
       jbe       short M02_L85
       lea       ecx,[r10+1]
       mov       [r12+10],ecx
       mov       ecx,r10d
       lea       rcx,[r8+rcx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L84
M02_L80:
       jmp       short M02_L76
M02_L81:
       mov       rcx,[rax]
       cmp       r10d,[rcx+14]
       jne       near ptr M02_L60
M02_L82:
       mov       rcx,[rax]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+8],rcx
       jmp       near ptr M02_L88
M02_L83:
       call      qword ptr [7FFD34125BD8]
       jmp       near ptr M02_L77
M02_L84:
       mov       rcx,[rbp-170]
       mov       r11,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rcx],r11
       jne       near ptr M02_L72
       jmp       short M02_L86
M02_L85:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L84
M02_L86:
       mov       rax,[rbp-170]
       add       rax,8
       mov       r8,[rax]
       mov       r10d,[rax+14]
       cmp       r10d,[r8+14]
       jne       short M02_L81
       mov       r9d,[rax+10]
       cmp       r9d,[r8+10]
       jae       short M02_L82
       mov       [rbp-1D8],rax
       lea       rcx,[rax+8]
       mov       r10,[r8+8]
       cmp       r9d,[r10+8]
       jae       near ptr M02_L61
       mov       edx,r9d
       mov       rdx,[r10+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-1D8]
       inc       dword ptr [rax+10]
       jmp       near ptr M02_L73
M02_L87:
       mov       rdx,r10
       call      qword ptr [7FFD34125BD8]
       jmp       near ptr M02_L64
M02_L88:
       mov       rdx,[rbp-170]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD34074348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L89
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rdx
       jne       near ptr M02_L138
M02_L89:
       mov       rdx,r12
       mov       rcx,1DA00200C60
       call      qword ptr [7FFD34076DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       r12,rax
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1DA5AC01EE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFD34249EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M02_L139
       jmp       near ptr M02_L34
M02_L90:
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,1DA00208858
       mov       r8,1DA00208870
       call      qword ptr [7FFD34076B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L91
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L91:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L92:
       mov       rcx,[r15+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rbp-188],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rbp-188]
       mov       [rbp-80],rdx
       mov       [rbp-78],rax
       lea       rdx,[rbp-0A0]
       mov       [rsp+20],rdx
       mov       edx,[r15+50]
       lea       rcx,[rbp-80]
       lea       r8,[rbp-88]
       lea       r9,[rbp-90]
       call      qword ptr [7FFD342C5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rbp-98]
       mov       [rbp-0A8],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-180],rax
       mov       r9,[r15+30]
       mov       rcx,rax
       mov       rdx,[rbp-0A8]
       mov       r8d,[rbp-0A0]
       call      qword ptr [7FFD34267B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r15+38]
       mov       rdx,[rbp-180]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L93:
       mov       rcx,r15
       mov       rax,[r13+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M02_L07
M02_L94:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3448DEA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3407F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L95:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD345842E8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFD33F24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD3407F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L96:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3448DEA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3407F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L97:
       call      qword ptr [7FFD3420E9D0]
       int       3
M02_L98:
       mov       rcx,1DA00208AE0
       mov       rdx,1DA00208AF8
       call      qword ptr [7FFD34076B08]; System.String.Concat(System.String, System.String)
       jmp       near ptr M02_L25
M02_L99:
       call      qword ptr [7FFD3420EF40]
       int       3
M02_L100:
       mov       rcx,1DA5AC01F00
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L101:
       xor       ecx,ecx
       jmp       near ptr M02_L04
M02_L102:
       mov       rcx,r15
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r13+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M02_L05
M02_L103:
       xor       r15d,r15d
       jmp       near ptr M02_L17
M02_L104:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L16
M02_L105:
       lea       rcx,[rbp-60]
       mov       rdx,r15
       call      qword ptr [7FFD341958F0]
       jmp       near ptr M02_L18
M02_L106:
       mov       rcx,r12
       call      qword ptr [7FFD3423D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L20
M02_L107:
       mov       rcx,[r12+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M02_L177
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-0E8],eax
       jne       short M02_L109
       mov       rcx,r12
       mov       [rbp-0E4],r10d
       mov       edx,r10d
       call      qword ptr [7FFD3423D7E8]
       mov       r9,rax
M02_L108:
       mov       r9,[r9+8]
       mov       [rbp-1B0],r9
       mov       rcx,7FFD33FB5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD33FB5C38],0
       je        near ptr M02_L118
       call      qword ptr [7FFD3407DC98]
       mov       edx,eax
       mov       [rbp-104],edx
       jmp       near ptr M02_L121
M02_L109:
       mov       [rbp-0E4],r10d
       jmp       short M02_L108
M02_L110:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M02_L09
M02_L111:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       je        near ptr M02_L10
M02_L112:
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       cmp       byte ptr [rbp-4C],0
       je        near ptr M02_L12
M02_L113:
       lea       rcx,[rbp-60]
       mov       rdx,r13
       call      qword ptr [7FFD34195848]
       jmp       near ptr M02_L13
M02_L114:
       lea       rcx,[rbp-60]
       mov       rdx,1DA002088C0
       call      qword ptr [7FFD341958F0]
       jmp       near ptr M02_L14
M02_L115:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195938]
M02_L116:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD340743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       edx,[rbp-50]
       cmp       edx,[rbp-40]
       ja        near ptr M02_L97
       mov       r9,[rbp-48]
       mov       r8d,edx
       lea       r9,[r9+r8*2]
       mov       r8d,[rbp-40]
       sub       r8d,edx
       xor       edx,edx
       mov       [rbp-148],r9
       mov       [rbp-140],r8d
       mov       [rbp-158],rdx
       xor       edx,edx
       mov       [rbp-150],edx
       mov       rdx,[rbp-60]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-148]
       lea       r9,[rbp-158]
       lea       r8,[rbp-0E0]
       mov       r11,7FFD33F30708
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L115
       mov       ecx,[rbp-50]
       add       ecx,[rbp-0E0]
       mov       [rbp-50],ecx
       jmp       near ptr M02_L18
M02_L117:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
       jmp       near ptr M02_L19
M02_L118:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-108],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-108]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L119
       call      qword ptr [7FFD345A7078]
       mov       edx,eax
       jmp       short M02_L120
M02_L119:
       mov       edx,ecx
       sar       edx,10
M02_L120:
       mov       [rbp-104],edx
M02_L121:
       mov       rcx,7FFD33FB5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-104]
       xor       edx,edx
       div       dword ptr [7FFD33FB5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L128
M02_L122:
       cmp       eax,[r8+8]
       jae       near ptr M02_L177
       mov       [rbp-0FC],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-1B8],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-10C],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1B8]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-110],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L124
       test      r10d,r10d
       jne       short M02_L125
       xor       edx,edx
       mov       [rax+14],edx
M02_L123:
       movsxd    rdx,r10d
       mov       r8,[rbp-1A8]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-110]
       inc       ecx
       mov       rax,[rbp-1B8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-10C],1
M02_L124:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-10C]
       test      ecx,ecx
       je        short M02_L126
       mov       r8d,1
       jmp       short M02_L129
M02_L125:
       jmp       short M02_L123
M02_L126:
       mov       eax,[rbp-0FC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-1B0]
       cmp       [rcx+8],r8d
       jne       short M02_L127
       xor       r8d,r8d
M02_L127:
       mov       edx,[rbp-100]
       inc       edx
       mov       eax,r8d
M02_L128:
       mov       r8,[rbp-1B0]
       mov       [rbp-100],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L122
       xor       r8d,r8d
M02_L129:
       mov       eax,r8d
       mov       [rbp-0EC],eax
       mov       eax,[rbp-0E8]
       mov       r10d,[rbp-0E4]
       jmp       near ptr M02_L21
M02_L130:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-0EC]
       cmp       dword ptr [r15+8],0
       mov       [rbp-0E4],edx
       mov       [rbp-0E8],r8d
       mov       [rbp-190],r10
       mov       [rbp-0EC],eax
       je        near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0F0],eax
       mov       edx,[r15+8]
       mov       [rbp-0F4],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-190]
       mov       r8d,[rbp-0F0]
       mov       r9d,[rbp-0F4]
       mov       edx,3
       call      qword ptr [7FFD34127678]
       mov       eax,[rbp-0E8]
       test      [rbp-0EC],eax
       mov       [rbp-0E8],eax
       jne       near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rbp-190]
       mov       [rbp-198],rdx
       mov       [rbp-0F8],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-0E8]
       test      r12d,r12d
       jne       short M02_L131
       mov       rcx,[rbp-198]
       mov       edx,[rbp-0F8]
       mov       r8d,0FFFFFFFF
       jmp       short M02_L132
M02_L131:
       mov       rcx,[rbp-198]
       mov       edx,[rbp-0F8]
       mov       r8d,[rbp-0E4]
M02_L132:
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L133
       mov       eax,1
       jmp       short M02_L134
M02_L133:
       xor       eax,eax
M02_L134:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r15d
       call      qword ptr [7FFD3423E2B0]
       jmp       near ptr M02_L22
M02_L135:
       xor       ecx,ecx
       jmp       near ptr M02_L30
M02_L136:
       mov       rcx,r15
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r13+58]
       call      qword ptr [rax+38]
       jmp       near ptr M02_L31
M02_L137:
       mov       rcx,rax
       mov       r11,7FFD33F306E0
       call      qword ptr [r11]
       jmp       near ptr M02_L32
M02_L138:
       mov       rcx,rax
       mov       r11,7FFD33F306F8
       call      qword ptr [r11]
       jmp       near ptr M02_L89
M02_L139:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L35
M02_L140:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r13,rcx
       je        near ptr M02_L36
M02_L141:
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       cmp       byte ptr [rbp-4C],0
       je        near ptr M02_L37
M02_L142:
       lea       rcx,[rbp-60]
       mov       rdx,r13
       call      qword ptr [7FFD34195848]
       jmp       near ptr M02_L38
M02_L143:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208908
       call      qword ptr [7FFD341958F0]
       cmp       byte ptr [rbp-4C],0
       je        near ptr M02_L39
M02_L144:
       lea       rcx,[rbp-60]
       mov       rdx,r12
       call      qword ptr [7FFD34195848]
       jmp       near ptr M02_L40
M02_L145:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208928
       call      qword ptr [7FFD341958F0]
       jmp       near ptr M02_L41
M02_L146:
       mov       rcx,[rbp-168]
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       mov       rcx,1DA002021B8
       cmp       rax,rcx
       jne       near ptr M02_L148
       mov       rcx,[rbp-168]
       mov       edx,1C
       mov       rax,[rcx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       cmp       dword ptr [rax+8],0
       je        near ptr M02_L148
       mov       rcx,[rbp-168]
       mov       edx,1C
       mov       rax,[rcx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,r12
       call      qword ptr [7FFD34484030]
       mov       r12,rax
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r12
       mov       rcx,1DA00208858
       mov       r8,1DA00208940
       call      qword ptr [7FFD34076B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L147
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L147:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L148:
       mov       rcx,1DA00208960
       mov       rax,[rbp-168]
       cmp       rax,rcx
       je        near ptr M02_L149
       mov       rcx,1DA00208660
       cmp       rax,rcx
       je        near ptr M02_L149
       mov       rcx,1DA00204FC0
       cmp       rax,rcx
       je        near ptr M02_L149
       mov       rcx,1DA00208988
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA00205F58
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA002089B0
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA002089D8
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA00208A00
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA00208A28
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA00204B88
       cmp       rax,rcx
       je        short M02_L149
       mov       rcx,1DA00208A50
       cmp       rax,rcx
       jne       near ptr M02_L155
M02_L149:
       lea       rcx,[rbp-60]
       mov       edx,3
       mov       r8d,2
       call      qword ptr [7FFD341956B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L150
       mov       rcx,1DA00208864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L151
M02_L150:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
M02_L151:
       mov       rcx,r15
       mov       r13,[r15]
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,2
       jb        short M02_L152
       mov       rcx,1DA0020894C
       mov       eax,[rcx]
       mov       [rdx],eax
       mov       ecx,[rbp-50]
       add       ecx,2
       mov       [rbp-50],ecx
       jmp       short M02_L153
M02_L152:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208940
       call      qword ptr [7FFD341958F0]
M02_L153:
       lea       rcx,[rbp-60]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD342F6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L154
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L154:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L155:
       mov       rdx,1DA00208A78
       cmp       rax,rdx
       jne       near ptr M02_L157
       mov       rdx,r12
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFD34074408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm0,dword ptr [rax]
       vmovss    dword ptr [rbp-64],xmm0
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       mov       rcx,1DA5AC00428
       mov       rcx,[rcx]
       vmovss    xmm0,dword ptr [rbp-64]
       vmovss    dword ptr [rbp-130],xmm0
       call      qword ptr [7FFD3419F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovss    xmm0,dword ptr [rbp-130]
       mov       rdx,1DA00208AA0
       call      qword ptr [7FFD341BFA98]
       mov       r9,rax
       mov       rdx,r12
       mov       rcx,1DA00208858
       mov       r8,1DA00208940
       call      qword ptr [7FFD34076B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L156
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L156:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L157:
       mov       rdx,1DA00205718
       cmp       rax,rdx
       jne       near ptr M02_L159
       mov       rdx,r12
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFD34074408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm0,qword ptr [rax]
       vmovsd    qword ptr [rbp-70],xmm0
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,1DA5AC00428
       mov       rcx,[rcx]
       vmovsd    xmm0,qword ptr [rbp-70]
       vmovsd    qword ptr [rbp-138],xmm0
       call      qword ptr [7FFD3419F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovsd    xmm0,qword ptr [rbp-138]
       mov       rdx,1DA00208AA0
       call      qword ptr [7FFD341BFA38]; System.Number.FormatDouble(Double, System.String, System.Globalization.NumberFormatInfo)
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,1DA00208858
       mov       r8,1DA00208940
       call      qword ptr [7FFD34076B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L158
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L158:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L159:
       mov       rcx,1DA00203C30
       cmp       rax,rcx
       jne       near ptr M02_L161
       mov       rcx,r15
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       cmp       [rax],al
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFD340772A0]
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,1DA00208858
       mov       r8,1DA00208940
       call      qword ptr [7FFD34076B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L160
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L160:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L161:
       mov       rdx,1DA00208AB8
       cmp       rax,rdx
       jne       near ptr M02_L169
       mov       rdx,r12
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFD34074408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rcx,[rax]
       mov       r8,1DA5AC00428
       mov       r8,[r8]
       mov       rdx,1DA00206808
       call      qword ptr [7FFD34604CC0]
       mov       r12,rax
       lea       rcx,[rbp-60]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341956B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L162
       mov       rcx,1DA00208864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L163
M02_L162:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
M02_L163:
       mov       rcx,r15
       mov       r13,[r15]
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L164
       mov       rcx,1DA002088CC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-50]
       add       ecx,3
       mov       [rbp-50],ecx
       jmp       short M02_L165
M02_L164:
       lea       rcx,[rbp-60]
       mov       rdx,1DA002088C0
       call      qword ptr [7FFD341958F0]
M02_L165:
       lea       rcx,[rbp-60]
       mov       rdx,r12
       call      qword ptr [7FFD34195830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L166
       mov       rcx,1DA00208864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L167
M02_L166:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
M02_L167:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L168
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L168:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L169:
       lea       rcx,[rbp-60]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341956B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L170
       mov       rcx,1DA00208864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L171
M02_L170:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
M02_L171:
       mov       rcx,r15
       mov       r13,[r15]
       mov       rax,[r13+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L172
       mov       rcx,1DA002088CC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-50]
       add       ecx,3
       mov       [rbp-50],ecx
       jmp       short M02_L173
M02_L172:
       lea       rcx,[rbp-60]
       mov       rdx,1DA002088C0
       call      qword ptr [7FFD341958F0]
M02_L173:
       lea       rcx,[rbp-60]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD342F6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M02_L97
       mov       rdx,[rbp-48]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-40]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L174
       mov       rcx,1DA00208864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
       jmp       short M02_L175
M02_L174:
       lea       rcx,[rbp-60]
       mov       rdx,1DA00208858
       call      qword ptr [7FFD341958F0]
M02_L175:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFD34195740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L176
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L176:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3412E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L177:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+220]
       mov       rdx,[rbp-170]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD34074348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L178
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [rax],rcx
       je        short M02_L178
       mov       rcx,rax
       mov       r11,7FFD33F306F8
       call      qword ptr [r11]
M02_L178:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 8650
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,298
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+120],xmm4
       vmovdqa   xmmword ptr [rsp+130],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M03_L01:
       vmovdqa   xmmword ptr [rsp+rax+290],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2B0],xmm4
       add       rax,30
       jne       short M03_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M03_L128
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+220]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFD33FC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+230],0
       je        near ptr M03_L122
       cmp       dword ptr [rsp+230],1
       jne       short M03_L02
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rsp+228]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L05
M03_L02:
       mov       r13d,[rsp+230]
       test      r13d,r13d
       jl        near ptr M03_L123
       mov       r15,[rsp+220]
       test      r15,r15
       je        near ptr M03_L124
       cmp       [r15+8],r13d
       je        short M03_L04
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r13d,r8d
       cmovg     r13d,r8d
       mov       r8d,r13d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M03_L33
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M03_L03:
       mov       [rsp+220],r12
M03_L04:
       mov       ecx,[rsp+230]
       mov       [rsp+234],ecx
       mov       r15,[rsp+220]
M03_L05:
       mov       rcx,1DA5AC04E90
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M03_L25
M03_L06:
       mov       rcx,1DA5AC04E98
       mov       r9,[rcx]
       test      r9,r9
       je        short M03_L08
M03_L07:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFD34486880]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r15,rax
       cmp       [rbx],r14
       jne       near ptr M03_L129
       mov       rcx,rbx
       jmp       near ptr M03_L52
M03_L08:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1DA5AC04E88
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD344826E8
       mov       [r12+18],rcx
       mov       rcx,1DA5AC04E98
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r12
       jmp       short M03_L07
M03_L09:
       mov       r12d,1
       xor       ebx,ebx
       mov       [rsp+110],rbx
       xor       eax,eax
       mov       [rsp+108],rax
       xor       r10d,r10d
       mov       [rsp+100],r10
       xor       r9d,r9d
       mov       [rsp+0F8],r9
M03_L10:
       mov       r11,rdi
       mov       r8d,ebp
       test      r8d,r8d
       je        near ptr M03_L132
       movzx     ecx,word ptr [r11]
       cmp       ecx,7B
       je        near ptr M03_L24
       cmp       ecx,7D
       je        near ptr M03_L22
       cmp       ecx,22
       jne       short M03_L12
       cmp       r12d,9
       jne       near ptr M03_L19
M03_L11:
       mov       edx,7
       jmp       short M03_L16
M03_L12:
       cmp       ecx,3A
       jne       short M03_L13
       mov       edx,9
       jmp       short M03_L16
M03_L13:
       cmp       ecx,2C
       jne       short M03_L14
       mov       edx,8
       jmp       short M03_L16
M03_L14:
       cmp       ecx,5B
       jne       short M03_L15
       mov       edx,0A
       jmp       short M03_L16
M03_L15:
       cmp       ecx,5D
       jne       near ptr M03_L125
       mov       edx,0B
M03_L16:
       mov       ecx,edx
       mov       [rsp+21C],ecx
       cmp       ecx,6
       je        short M03_L17
       cmp       ecx,7
       jne       near ptr M03_L57
M03_L17:
       cmp       ecx,6
       jne       near ptr M03_L53
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1F0],xmm0
       cmp       r8d,1
       jb        near ptr M03_L121
       add       r11,2
       sub       r8d,1
       mov       [rsp+50],r11
       mov       [rsp+144],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD342F56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+204],eax
       cmp       eax,[rsp+144]
       ja        near ptr M03_L121
       mov       rcx,[rsp+50]
       mov       [rsp+1F0],rcx
       mov       [rsp+1F8],eax
       lea       rcx,[rsp+1F0]
       call      qword ptr [7FFD3412C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+48],rax
       mov       edx,[rsp+204]
       add       edx,2
       mov       [rsp+140],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+90],rax
       mov       dword ptr [rax+10],6
       mov       edx,[rsp+140]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+90]
M03_L18:
       mov       r8,rax
       jmp       short M03_L21
M03_L19:
       mov       edx,6
       jmp       near ptr M03_L16
M03_L20:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       eax,[rsp+21C]
       mov       [r8+10],eax
       mov       dword ptr [r8+14],1
       mov       byte ptr [r8+18],0
M03_L21:
       mov       rdx,r8
       mov       [rsp+0F0],rdx
       mov       r8d,[rdx+10]
       mov       [rsp+294],r8d
       mov       r11d,[rdx+14]
       mov       [rsp+290],r11d
       cmp       r8d,2
       je        near ptr M03_L92
       jmp       short M03_L23
M03_L22:
       mov       edx,5
       jmp       near ptr M03_L16
M03_L23:
       cmp       r8d,8
       je        short M03_L26
       jmp       near ptr M03_L55
M03_L24:
       mov       edx,4
       jmp       near ptr M03_L16
M03_L25:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1DA5AC04E88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD344826D0
       mov       [r13+18],rcx
       mov       rcx,1DA5AC04E90
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L06
M03_L26:
       cmp       r12d,7
       jne       near ptr M03_L32
       mov       rax,[rsp+108]
       test      rax,rax
       je        near ptr M03_L56
       cmp       dword ptr [rax+10],6
       jne       near ptr M03_L56
       mov       [rsp+108],rax
       mov       rcx,[rax+8]
       test      rcx,rcx
       mov       rax,[rsp+108]
       je        near ptr M03_L56
       mov       r10,[rsp+100]
       test      r10,r10
       je        short M03_L31
       mov       [rsp+100],r10
       cmp       dword ptr [r10+10],9
       jne       near ptr M03_L56
       mov       r9,[rsp+0F8]
       test      r9,r9
       je        short M03_L30
       cmp       dword ptr [r9+10],7
       jne       short M03_L29
       mov       [rsp+0F8],r9
       movzx     ebx,byte ptr [r9+18]
M03_L27:
       test      ebx,ebx
       je        near ptr M03_L56
       mov       [rsp+0B0],rcx
       mov       rbx,rcx
       test      rbx,rbx
       je        short M03_L28
       jmp       near ptr M03_L59
M03_L28:
       mov       [rsp+108],rax
       jmp       near ptr M03_L60
M03_L29:
       mov       r10,[rsp+100]
       jmp       near ptr M03_L58
M03_L30:
       mov       r10,[rsp+100]
       jmp       near ptr M03_L58
M03_L31:
       mov       [rsp+100],r10
       jmp       near ptr M03_L56
M03_L32:
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L33:
       call      qword ptr [7FFD34125BD8]
       jmp       near ptr M03_L03
M03_L34:
       cmp       r8d,0A
       je        short M03_L36
M03_L35:
       mov       r8d,[rsp+294]
       cmp       r8d,5
       je        near ptr M03_L90
       cmp       r8d,8
       je        near ptr M03_L85
       cmp       r8d,3
       je        near ptr M03_L85
       cmp       r8d,6
       jne       near ptr M03_L87
       jmp       near ptr M03_L89
M03_L36:
       cmp       r12d,9
       jne       short M03_L35
       mov       [rsp+108],rax
       mov       rcx,rax
       call      qword ptr [7FFD34484078]; Ferris.Json.JsonTransformer.IsValidPropertyNameToken(Ferris.Json.TokenInfo)
       test      eax,eax
       je        near ptr M03_L46
       mov       rax,[rsp+100]
       test      rax,rax
       je        near ptr M03_L152
       mov       [rsp+100],rax
       xor       ecx,ecx
       cmp       dword ptr [rax+10],9
       sete      cl
M03_L37:
       test      ecx,ecx
       je        near ptr M03_L45
       mov       r8,[rsp+108]
       mov       rdx,[r8+8]
       mov       r10,rdx
       test      r10,r10
       je        short M03_L38
       mov       rcx,offset MT_System.String
       cmp       [r10],rcx
       jne       near ptr M03_L120
M03_L38:
       cmp       [r15],r15b
       mov       rcx,r15
       mov       rdx,r10
       call      qword ptr [7FFD3407EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M03_L44
       mov       rcx,[rax]
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L153
       call      qword ptr [7FFD34334EB8]; System.Reflection.RuntimePropertyInfo.get_Signature()
       mov       rax,[rax+18]
       cmp       [rax],r14
       jne       near ptr M03_L154
       mov       [rsp+0E8],rax
       mov       rcx,rax
       call      qword ptr [7FFD33FBA518]; System.RuntimeType.get_IsGenericType()
M03_L39:
       test      eax,eax
       je        near ptr M03_L111
       mov       rdx,[rsp+0E8]
       mov       r8,[rdx]
       mov       [rsp+118],r8
       cmp       r8,r14
       jne       near ptr M03_L155
       mov       [rsp+0E8],rdx
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FBA568]; System.RuntimeType.GetGenericTypeDefinition()
M03_L40:
       mov       rcx,1DA00208B60
       cmp       rax,rcx
       jne       near ptr M03_L111
       mov       r12,[rsp+118]
       cmp       r12,r14
       jne       near ptr M03_L156
       mov       rcx,[rsp+0E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FBA578]; System.RuntimeType.GetGenericArguments()
M03_L41:
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L164
       mov       r12,[rax+10]
       mov       rcx,[rsp+0E8]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD34236028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD340743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0E0],rax
       test      r12,r12
       je        near ptr M03_L99
       cmp       [r12],r14
       jne       near ptr M03_L99
M03_L42:
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       dec       ebp
       mov       rcx,1DA00200020
       cmp       r12,rcx
       je        near ptr M03_L157
       cmp       [r12],r12b
       mov       rcx,r12
       call      qword ptr [7FFD33FC7330]; System.RuntimeType.GetBaseType()
       mov       rdx,1DA002021B8
       cmp       rax,rdx
       jne       near ptr M03_L157
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       mov       rdx,r12
       lea       r8,[rsp+120]
       lea       rcx,[rsp+170]
       call      qword ptr [7FFD34484108]
M03_L43:
       mov       rdx,[rsp+170]
       mov       rdi,[rsp+178]
       mov       ebp,[rsp+180]
       test      ebp,ebp
       je        near ptr M03_L158
       test      ebp,ebp
       je        near ptr M03_L164
       movzx     eax,word ptr [rdi]
       cmp       eax,7B
       je        short M03_L47
       cmp       eax,7D
       jne       near ptr M03_L93
       jmp       near ptr M03_L96
M03_L44:
       mov       rax,[rsp+108]
       mov       r8d,[rsp+294]
       jmp       near ptr M03_L85
M03_L45:
       mov       rax,[rsp+108]
       mov       r8d,[rsp+294]
       jmp       near ptr M03_L85
M03_L46:
       mov       rax,[rsp+108]
       mov       r8d,[rsp+294]
       jmp       near ptr M03_L85
M03_L47:
       mov       r8d,4
M03_L48:
       mov       [rsp+26C],r8d
       mov       rcx,[rsp+0E0]
       mov       r11,7FFD33F306B8
       call      qword ptr [r11]
       mov       eax,[rsp+26C]
       cmp       eax,8
       je        near ptr M03_L42
M03_L49:
       cmp       eax,0B
       jne       short M03_L50
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       dec       ebp
M03_L50:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+0E0]
       call      CORINFO_HELP_ASSIGN_REF
M03_L51:
       mov       eax,7
       mov       [rsp+0F8],r12
       mov       r12d,eax
       jmp       near ptr M03_L10
M03_L52:
       test      rcx,rcx
       je        near ptr M03_L130
       cmp       [rcx],r14
       jne       near ptr M03_L130
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FC6E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M03_L131
       jmp       near ptr M03_L09
M03_L53:
       cmp       ecx,7
       jne       near ptr M03_L138
       test      r8d,r8d
       je        near ptr M03_L164
       movzx     ecx,word ptr [r11]
       cmp       ecx,22
       jne       near ptr M03_L137
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1D8],xmm0
       cmp       r8d,1
       jb        near ptr M03_L121
       add       r11,2
       sub       r8d,1
       mov       [rsp+40],r11
       mov       [rsp+13C],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD342F56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jle       short M03_L54
       lea       ecx,[rax-1]
       mov       edx,[rsp+13C]
       cmp       ecx,edx
       jae       near ptr M03_L164
       lea       ecx,[rax-1]
       mov       r11,[rsp+40]
       cmp       word ptr [r11+rcx*2],5C
       je        near ptr M03_L133
M03_L54:
       cmp       eax,[rsp+13C]
       ja        near ptr M03_L121
       mov       r11,[rsp+40]
       mov       [rsp+1EC],eax
       mov       ecx,eax
       mov       [rsp+1D8],r11
       mov       [rsp+1E0],ecx
       lea       rcx,[rsp+1D8]
       call      qword ptr [7FFD3412C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+38],rax
       mov       edx,[rsp+1EC]
       add       edx,2
       mov       [rsp+138],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       dword ptr [rax+10],7
       mov       edx,[rsp+138]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       jmp       near ptr M03_L18
M03_L55:
       mov       r8d,[rsp+294]
       cmp       r8d,5
       je        near ptr M03_L26
       mov       rax,[rsp+108]
M03_L56:
       mov       r8d,[rsp+294]
       cmp       r8d,4
       jne       near ptr M03_L34
       cmp       r12d,9
       je        near ptr M03_L148
       jmp       near ptr M03_L34
M03_L57:
       cmp       ecx,3
       je        near ptr M03_L139
       jmp       near ptr M03_L20
M03_L58:
       xor       edx,edx
       mov       [rsp+0F8],r9
       mov       [rsp+100],r10
       mov       ebx,edx
       jmp       near ptr M03_L27
M03_L59:
       mov       [rsp+108],rax
       mov       rax,offset MT_System.String
       cmp       [rbx],rax
       jne       near ptr M03_L115
M03_L60:
       cmp       [r15],r15b
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD3407EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M03_L75
       mov       rbx,[rax]
       mov       rax,[rsp+0F8]
       cmp       byte ptr [rax+18],0
       je        near ptr M03_L74
       mov       [rsp+0F8],rax
       mov       rdx,[rax+8]
       mov       [rsp+88],rdx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L141
       mov       rcx,rbx
       cmp       qword ptr [rcx+38],0
       je        near ptr M03_L83
M03_L61:
       mov       rcx,[rbx+38]
       mov       r8,[rcx+18]
M03_L62:
       mov       r10,r8
       mov       [rsp+80],r10
       mov       rcx,1DA00200020
       cmp       r10,rcx
       jne       near ptr M03_L81
M03_L63:
       mov       rcx,offset MT_System.String
       mov       rdx,[rsp+88]
       cmp       [rdx],rcx
       jne       near ptr M03_L91
       mov       rcx,rdx
M03_L64:
       test      rcx,rcx
       je        short M03_L65
       mov       rdx,1DA00208B88
       xor       r8d,r8d
       call      qword ptr [7FFD340762F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       mov       rdx,[rsp+88]
       jne       near ptr M03_L140
M03_L65:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L147
       cmp       qword ptr [rbx+20],0
       je        near ptr M03_L144
       mov       rbx,[rbx+20]
M03_L66:
       test      rbx,rbx
       je        near ptr M03_L116
       cmp       qword ptr [rbx+48],0
       je        near ptr M03_L80
M03_L67:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       je        short M03_L68
       mov       rcx,rbx
       call      qword ptr [7FFD342658F0]
M03_L68:
       test      byte ptr [rbx+5C],10
       jne       short M03_L71
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M03_L145
       mov       rcx,[rbx+38]
       cmp       [rcx],r14
       jne       near ptr M03_L146
M03_L69:
       mov       rdx,r13
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
M03_L70:
       test      eax,eax
       je        near ptr M03_L117
M03_L71:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M03_L79
M03_L72:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M03_L118
       cmp       qword ptr [rbx+48],0
       je        short M03_L77
M03_L73:
       mov       rax,[rsp+88]
       mov       [rsp+20],rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbx+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD342679C0]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L74:
       mov       [rsp+0F8],rax
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L75:
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L76:
       cmp       r8d,4
       jne       near ptr M03_L85
       jmp       short M03_L78
M03_L77:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD342678A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L73
M03_L78:
       mov       rbx,[rsp+110]
       test      rbx,rbx
       mov       [rsp+110],rbx
       jne       near ptr M03_L85
       jmp       near ptr M03_L84
M03_L79:
       mov       rcx,rbx
       call      qword ptr [7FFD34265920]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M03_L72
M03_L80:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+68],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD342678A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+88]
       jmp       near ptr M03_L67
M03_L81:
       cmp       [r10],r14
       jne       near ptr M03_L142
       mov       rcx,r10
       call      qword ptr [7FFD33FC7330]; System.RuntimeType.GetBaseType()
M03_L82:
       mov       rcx,1DA002021B8
       cmp       rax,rcx
       jne       near ptr M03_L143
       jmp       near ptr M03_L63
M03_L83:
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+70],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+70]
       mov       [rsp+1B0],rdx
       mov       [rsp+1B8],rax
       lea       rdx,[rsp+190]
       mov       [rsp+20],rdx
       mov       edx,[rbx+50]
       lea       rcx,[rsp+1B0]
       lea       r8,[rsp+1A8]
       lea       r9,[rsp+1A0]
       call      qword ptr [7FFD342C5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+198]
       mov       [rsp+188],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+78],rax
       mov       r9,[rbx+30]
       mov       rcx,rax
       mov       rdx,[rsp+188]
       mov       r8d,[rsp+190]
       call      qword ptr [7FFD34267B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[rbx+38]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L61
M03_L84:
       mov       rdx,[rsp+0F0]
       mov       rbx,rdx
       mov       [rsp+110],rbx
M03_L85:
       cmp       r8d,3
       je        short M03_L86
       mov       r12d,r8d
M03_L86:
       mov       r11d,[rsp+290]
       cmp       r11d,ebp
       ja        near ptr M03_L121
       mov       r8d,r11d
       lea       rdi,[rdi+r8*2]
       sub       ebp,r11d
       mov       [rsp+108],rax
       jmp       near ptr M03_L10
M03_L87:
       cmp       r8d,9
       jne       short M03_L88
       mov       rdx,[rsp+0F0]
       mov       r10,rdx
       mov       [rsp+100],r10
       jmp       short M03_L85
M03_L88:
       cmp       r8d,7
       jne       near ptr M03_L76
       mov       rdx,[rsp+0F0]
       mov       r9,rdx
       mov       [rsp+0F8],r9
       jmp       short M03_L85
M03_L89:
       mov       rdx,[rsp+0F0]
       mov       [rsp+108],rdx
       mov       rax,[rsp+108]
       jmp       near ptr M03_L85
M03_L90:
       mov       r11d,[rsp+290]
       cmp       r11d,ebp
       ja        near ptr M03_L121
       mov       eax,r11d
       lea       rdi,[rdi+rax*2]
       sub       ebp,r11d
       jmp       short M03_L92
M03_L91:
       mov       rcx,rdx
       mov       r8,[rdx]
       mov       r8,[r8+40]
       call      qword ptr [r8+8]
       mov       rcx,rax
       mov       rdx,[rsp+88]
       jmp       near ptr M03_L64
M03_L92:
       mov       rcx,rsi
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,298
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L93:
       cmp       eax,22
       jne       short M03_L94
       mov       r8d,6
       jmp       near ptr M03_L48
M03_L94:
       cmp       eax,3A
       jne       short M03_L95
       mov       r8d,9
       jmp       near ptr M03_L48
M03_L95:
       cmp       eax,2C
       jne       short M03_L97
       mov       r8d,8
       jmp       near ptr M03_L48
M03_L96:
       mov       eax,5
       mov       r8d,eax
       jmp       near ptr M03_L48
M03_L97:
       cmp       eax,5B
       jne       short M03_L98
       mov       r8d,0A
       jmp       near ptr M03_L48
M03_L98:
       cmp       eax,5D
       jne       near ptr M03_L159
       mov       r8d,0B
       jmp       near ptr M03_L48
M03_L99:
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       dec       ebp
       mov       rcx,1DA00200020
       cmp       r12,rcx
       je        near ptr M03_L162
       cmp       [r12],r14
       jne       near ptr M03_L161
       cmp       [r12],r12b
       mov       rcx,r12
       call      qword ptr [7FFD33FC7330]; System.RuntimeType.GetBaseType()
M03_L100:
       mov       rdx,1DA002021B8
       cmp       rax,rdx
       jne       near ptr M03_L162
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       mov       rdx,r12
       lea       r8,[rsp+120]
       lea       rcx,[rsp+170]
       call      qword ptr [7FFD34484108]
M03_L101:
       mov       rdx,[rsp+170]
       mov       rdi,[rsp+178]
       mov       ebp,[rsp+180]
       test      ebp,ebp
       je        near ptr M03_L163
       test      ebp,ebp
       je        near ptr M03_L164
       movzx     eax,word ptr [rdi]
       cmp       eax,7B
       je        short M03_L105
       cmp       eax,7D
       je        short M03_L106
       cmp       eax,22
       jne       short M03_L103
       mov       eax,6
M03_L102:
       mov       [rsp+26C],eax
       mov       rcx,[rsp+0E0]
       mov       r11,7FFD33F306B8
       call      qword ptr [r11]
       mov       eax,[rsp+26C]
       cmp       eax,8
       je        near ptr M03_L99
       mov       r12d,eax
       mov       eax,r12d
       jmp       near ptr M03_L49
M03_L103:
       cmp       eax,3A
       jne       short M03_L104
       mov       eax,9
       jmp       short M03_L102
M03_L104:
       cmp       eax,2C
       jne       short M03_L107
       mov       eax,8
       jmp       short M03_L102
M03_L105:
       mov       eax,4
       jmp       short M03_L102
M03_L106:
       mov       eax,5
       jmp       short M03_L102
M03_L107:
       cmp       eax,5B
       jne       short M03_L108
       mov       eax,0A
       jmp       short M03_L102
M03_L108:
       cmp       eax,5D
       jne       short M03_L109
       mov       eax,0B
       jmp       short M03_L102
M03_L109:
       cmp       eax,20
       jne       short M03_L110
       mov       r9d,3
       mov       eax,r9d
       jmp       near ptr M03_L102
M03_L110:
       xor       r9d,r9d
       mov       eax,r9d
       jmp       near ptr M03_L102
M03_L111:
       mov       rcx,[rsp+0E8]
       mov       [rsp+0E8],rcx
       mov       rax,[rcx]
       mov       [rsp+118],rax
       mov       rdx,[rax+58]
       call      qword ptr [rdx+10]
       test      eax,eax
       je        near ptr M03_L114
       mov       rcx,[rsp+0E8]
       mov       r12,[rsp+118]
       mov       rax,[r12+68]
       call      qword ptr [rax+8]
       mov       r12,rax
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0D0],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+0D0]
       mov       rcx,1DA00208B60
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FBA758]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD34236028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD340743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0D8],rax
M03_L112:
       cmp       ebp,1
       jb        near ptr M03_L121
       lea       rdx,[rdi+2]
       lea       r8d,[rbp-1]
       mov       [rsp+120],rdx
       mov       [rsp+128],r8d
       mov       rdx,r12
       lea       r8,[rsp+120]
       lea       rcx,[rsp+250]
       call      qword ptr [7FFD34484108]
       mov       rdi,[rsp+258]
       mov       ebp,[rsp+260]
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       rdx,[rsp+120]
       mov       ecx,1
       call      qword ptr [7FFD344841C8]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+268],eax
       mov       rcx,[rsp+0D8]
       mov       rdx,[rsp+250]
       mov       r11,7FFD33F306A0
       call      qword ptr [r11]
       mov       ecx,[rsp+268]
       cmp       ecx,8
       je        near ptr M03_L112
       mov       rax,[rsp+0D8]
       cmp       ecx,0B
       jne       short M03_L113
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       dec       ebp
M03_L113:
       mov       rcx,rax
       mov       r11,7FFD33F306A8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FFD33FC7678]; System.Array.CreateInstance(System.Type, Int32)
       mov       r12,rax
       mov       rcx,[rsp+0D8]
       mov       rdx,r12
       mov       r11,7FFD33F306B0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       dword ptr [rax+10],7
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+0C8]
       jmp       near ptr M03_L51
M03_L114:
       mov       rcx,[rsp+0E8]
       mov       rax,[rsp+118]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rax,[rsp+108]
       mov       r8d,[rsp+294]
       jmp       near ptr M03_L85
M03_L115:
       mov       rcx,rax
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFD340743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L116:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3448E9D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3407F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L117:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD34587000]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD34335998]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L118:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3448E7F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34335908]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L119:
       mov       rcx,rdx
       mov       rdx,[rsp+0C0]
       call      qword ptr [7FFD340743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L120:
       call      qword ptr [7FFD340743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L121:
       call      qword ptr [7FFD3420E9D0]
       int       3
M03_L122:
       mov       rcx,1DA5AC01F30
       mov       r15,[rcx]
       jmp       near ptr M03_L05
M03_L123:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD3420ED48]
       int       3
M03_L124:
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+220],rax
       jmp       near ptr M03_L04
M03_L125:
       mov       rax,[rsp+108]
       mov       r10,[rsp+100]
       cmp       ecx,20
       jne       short M03_L126
       mov       edx,3
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M03_L16
M03_L126:
       cmp       r12d,9
       je        short M03_L127
       xor       edx,edx
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M03_L16
M03_L127:
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M03_L11
M03_L128:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M03_L05
M03_L129:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M03_L52
M03_L130:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD3448E4C0]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFD33F24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFD3407F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L131:
       mov       [rsp+240],rdi
       mov       [rsp+248],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+238]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+248]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,298
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L132:
       mov       rax,[rsp+108]
       mov       r10,[rsp+100]
       mov       edx,2
       mov       [rsp+108],rax
       mov       [rsp+100],r10
       jmp       near ptr M03_L16
M03_L133:
       mov       r10,[rsp+100]
       mov       r11d,eax
       mov       r8,[rsp+40]
       mov       [rsp+30],r8
       mov       edx,[rsp+13C]
       mov       [rsp+134],edx
       jmp       short M03_L135
M03_L134:
       lea       ecx,[rax+1]
       cmp       ecx,[rsp+134]
       mov       [rsp+100],r10
       ja        near ptr M03_L121
       mov       eax,ecx
       mov       r11,[rsp+30]
       lea       r11,[r11+rax*2]
       mov       eax,[rsp+134]
       sub       eax,ecx
       mov       edx,22
       mov       [rsp+30],r11
       mov       rcx,r11
       mov       [rsp+134],eax
       mov       r8d,eax
       call      qword ptr [7FFD342F56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       edx,eax
       mov       ecx,[rsp+1D4]
       lea       ecx,[rcx+rdx+1]
       mov       eax,edx
       mov       r11d,ecx
       mov       edx,[rsp+13C]
       mov       r8,[rsp+40]
       mov       r10,[rsp+100]
M03_L135:
       test      eax,eax
       jle       short M03_L136
       lea       ecx,[r11-1]
       cmp       ecx,edx
       jae       near ptr M03_L164
       mov       [rsp+1D4],r11d
       lea       ecx,[r11-1]
       cmp       word ptr [r8+rcx*2],5C
       je        near ptr M03_L134
       mov       edx,[rsp+13C]
       mov       r8,[rsp+40]
       mov       r11d,[rsp+1D4]
M03_L136:
       mov       ecx,r11d
       mov       [rsp+100],r10
       mov       eax,ecx
       jmp       near ptr M03_L54
M03_L137:
       mov       [rsp+120],r11
       mov       [rsp+128],r8d
       lea       rdx,[rsp+120]
       lea       rcx,[rsp+208]
       call      qword ptr [7FFD34484198]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       rcx,rax
       mov       edx,7
       mov       r8d,[rsp+210]
       call      qword ptr [7FFD34486610]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+208]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       jmp       near ptr M03_L18
M03_L138:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsp+21C]
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       jmp       near ptr M03_L18
M03_L139:
       mov       [rsp+120],r11
       mov       [rsp+128],r8d
       lea       rcx,[rsp+120]
       call      qword ptr [7FFD34484150]
       mov       [rsp+218],eax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rsp+0A8],r8
       mov       rcx,r8
       mov       edx,3
       mov       r8d,[rsp+218]
       call      qword ptr [7FFD34486610]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       r8,[rsp+0A8]
       mov       rcx,r8
       mov       r8,rcx
       jmp       near ptr M03_L21
M03_L140:
       mov       rcx,rbx
       mov       rdx,r13
       xor       r8d,r8d
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L141:
       mov       rcx,rbx
       mov       r9,[rbx]
       mov       r9,[r9+50]
       call      qword ptr [r9+10]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M03_L62
M03_L142:
       mov       rcx,r10
       mov       r8,[r10]
       mov       r8,[r8+98]
       call      qword ptr [r8+20]
       jmp       near ptr M03_L82
M03_L143:
       mov       rcx,[rsp+80]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L63
       mov       r10,[rsp+80]
       lea       rcx,[rsp+1C0]
       mov       rdx,r10
       mov       r8,[rsp+88]
       call      qword ptr [7FFD34486850]
       mov       rcx,rbx
       mov       rdx,r13
       mov       r8,[rsp+1C0]
       xor       r9d,r9d
       mov       rax,[rbx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L144:
       xor       ebx,ebx
       jmp       near ptr M03_L66
M03_L145:
       xor       ecx,ecx
       cmp       [rcx],r14
       je        near ptr M03_L69
M03_L146:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       jmp       near ptr M03_L70
M03_L147:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r8,[rsp+88]
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       mov       rax,[rsp+108]
       jmp       near ptr M03_L56
M03_L148:
       mov       r10,[rsp+100]
       mov       [rsp+108],rax
       mov       rcx,rax
       mov       [rsp+100],r10
       mov       rdx,r10
       call      qword ptr [7FFD344840C0]; Ferris.Json.JsonTransformer.AreTokensSetupForPropertyValue(Ferris.Json.TokenInfo, Ferris.Json.TokenInfo)
       test      eax,eax
       mov       rax,[rsp+108]
       mov       r8d,[rsp+294]
       je        near ptr M03_L85
       mov       [rsp+108],rax
       mov       rdx,[rax+8]
       mov       [rsp+0C0],rdx
       mov       rcx,rdx
       mov       [rsp+0B8],rcx
       test      rcx,rcx
       je        near ptr M03_L151
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       jne       near ptr M03_L119
M03_L149:
       lea       r8,[rsp+288]
       mov       rcx,r15
       mov       rdx,[rsp+0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34104630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       mov       r8d,[rsp+294]
       je        near ptr M03_L150
       mov       rcx,[rsp+288]
       mov       rdx,[rsp+288]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rdx,rax
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       r8,[rsp+120]
       lea       rcx,[rsp+270]
       call      qword ptr [7FFD34484108]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+270]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,7
       mov       rdi,[rsp+278]
       mov       ecx,[rsp+280]
       mov       eax,ecx
       mov       [rsp+0F8],r12
       mov       r12d,ebp
       mov       ebp,eax
       jmp       near ptr M03_L10
M03_L150:
       mov       rax,[rsp+108]
       jmp       near ptr M03_L85
M03_L151:
       jmp       near ptr M03_L149
M03_L152:
       xor       ecx,ecx
       mov       [rsp+100],rax
       jmp       near ptr M03_L37
M03_L153:
       mov       rdx,[rcx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
M03_L154:
       mov       rcx,rax
       mov       [rsp+0E8],rax
       mov       rdx,[rax]
       mov       rdx,[rdx+60]
       call      qword ptr [rdx+8]
       jmp       near ptr M03_L39
M03_L155:
       mov       [rsp+0E8],rdx
       mov       rcx,rdx
       mov       r8,[rsp+118]
       mov       rax,[r8+68]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L40
M03_L156:
       mov       rcx,[rsp+0E8]
       mov       rax,[r12+68]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L41
M03_L157:
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       rdx,[rsp+120]
       mov       ecx,7
       call      qword ptr [7FFD344841B0]; Ferris.Json.JsonTransformer.ExtractTokenData(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+58],rax
       mov       r8,[rax+8]
       lea       rcx,[rsp+160]
       mov       rdx,r12
       call      qword ptr [7FFD34486850]
       mov       rax,[rsp+160]
       mov       rdx,[rsp+58]
       mov       r8d,[rdx+14]
       cmp       r8d,ebp
       ja        near ptr M03_L121
       mov       ecx,r8d
       lea       r10,[rdi+rcx*2]
       sub       ebp,r8d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+148],xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       [rsp+150],r10
       mov       [rsp+158],ebp
       mov       [rsp+148],rax
       vmovdqu   xmm0,xmmword ptr [rsp+148]
       vmovdqu   xmmword ptr [rsp+170],xmm0
       mov       rcx,[rsp+158]
       mov       [rsp+180],rcx
       jmp       near ptr M03_L43
M03_L158:
       mov       r9d,2
       mov       r8d,r9d
       jmp       near ptr M03_L48
M03_L159:
       cmp       eax,20
       jne       short M03_L160
       mov       r9d,3
       mov       r8d,r9d
       jmp       near ptr M03_L48
M03_L160:
       xor       r9d,r9d
       mov       r8d,r9d
       jmp       near ptr M03_L48
M03_L161:
       mov       rcx,r12
       mov       rdx,[r12]
       mov       rdx,[rdx+98]
       call      qword ptr [rdx+20]
       jmp       near ptr M03_L100
M03_L162:
       mov       [rsp+120],rdi
       mov       [rsp+128],ebp
       lea       rdx,[rsp+120]
       mov       ecx,7
       call      qword ptr [7FFD344841B0]; Ferris.Json.JsonTransformer.ExtractTokenData(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+58],rax
       mov       r8,[rax+8]
       lea       rcx,[rsp+160]
       mov       rdx,r12
       call      qword ptr [7FFD34486850]
       mov       rax,[rsp+160]
       mov       rcx,[rsp+58]
       mov       r8d,[rcx+14]
       cmp       r8d,ebp
       ja        near ptr M03_L121
       mov       ecx,r8d
       lea       r10,[rdi+rcx*2]
       sub       ebp,r8d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+148],xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       [rsp+150],r10
       mov       [rsp+158],ebp
       mov       [rsp+148],rax
       vmovdqu   xmm0,xmmword ptr [rsp+148]
       vmovdqu   xmmword ptr [rsp+170],xmm0
       mov       rcx,[rsp+158]
       mov       [rsp+180],rcx
       jmp       near ptr M03_L101
M03_L163:
       mov       r9d,2
       mov       eax,r9d
       jmp       near ptr M03_L102
M03_L164:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6946
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFD34074348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M04_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M04_L05
M04_L00:
       mov       rax,rbx
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       ecx,1D4F
       mov       rdx,7FFD33F24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD342366E8]
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M04_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD34585A70]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD34486F40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD34585B00]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD34486F40]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L06:
       mov       rcx,1DA00203C30
       cmp       rsi,rcx
       jne       short M04_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30790
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,1DA00208898
       cmp       rsi,rcx
       jne       short M04_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30788
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L08:
       mov       rcx,1DA00208A00
       cmp       rsi,rcx
       jne       short M04_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30780
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L09:
       mov       rcx,1DA002089D8
       cmp       rsi,rcx
       jne       short M04_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30778
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,1DA00208960
       cmp       rsi,rcx
       jne       short M04_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30770
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L11:
       mov       rcx,1DA00208660
       cmp       rsi,rcx
       jne       short M04_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30768
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L12:
       mov       rcx,1DA00204FC0
       cmp       rsi,rcx
       jne       short M04_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30760
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,1DA00208988
       cmp       rsi,rcx
       jne       short M04_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30758
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L14:
       mov       rcx,1DA00205F58
       cmp       rsi,rcx
       jne       short M04_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30750
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L15:
       mov       rcx,1DA002089B0
       cmp       rsi,rcx
       jne       short M04_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30748
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L16:
       mov       rcx,1DA00208A78
       cmp       rsi,rcx
       jne       short M04_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30740
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L17:
       mov       rcx,1DA00205718
       cmp       rsi,rcx
       jne       short M04_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30738
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L18:
       mov       rcx,1DA00208A28
       cmp       rsi,rcx
       jne       short M04_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFD33F30730
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L19:
       mov       rcx,1DA00208AB8
       cmp       rsi,rcx
       jne       short M04_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30728
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L20:
       mov       rcx,1DA00200020
       cmp       rsi,rcx
       jne       short M04_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F30720
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M04_L21:
       mov       rcx,1DA002021B8
       cmp       rsi,rcx
       je        near ptr M04_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFD33F30718
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M05_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M05_L02
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       jne       short M05_L00
M05_L03:
       jmp       qword ptr [7FFD340743A8]
; Total bytes of code 69
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFD3E3C41F8]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFD3E3D7B80]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD3E3D8B78]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.NewtonsoftListMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,1EFFC0041A8
       mov       rdi,[rsi]
       mov       rcx,1EFFC004E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M00_L04
       xor       ebp,ebp
M00_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD344A6D48]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbp,rbp
       jne       near ptr M00_L05
M00_L01:
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFD344A4420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       rdx,1EF80309120
       xor       r8d,r8d
       call      qword ptr [7FFD344A4510]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       r8,rax
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.MixedListTestObj
       cmp       [r8],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFD340843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L02:
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+10]
       mov       rax,[r8+8]
       cmp       ecx,[rax+10]
       jne       short M00_L03
       inc       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       dec       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,r14
       mov       rdx,rbp
       call      qword ptr [7FFD344A6DC0]
       jmp       near ptr M00_L01
; Total bytes of code 236
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,1EFFC004ED0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,1EFFC0050C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EFFC004ED8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EFFC0050B0
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1EFFC000428
       mov       r13,[rcx]
       mov       rcx,1EFFC0014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EF80301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,1EFFC005078
       mov       rax,1EFFC005080
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD3447A688
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3413D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD342C99F0]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD344AF540]
M02_L07:
       mov       rcx,[r14+8]
       test      rcx,rcx
       jne       short M02_L08
       xor       eax,eax
       jmp       short M02_L09
M02_L08:
       mov       eax,[rcx+10]
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       eax
M02_L10:
       test      eax,eax
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD33F41218
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 768
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       rcx,1EFFC004E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M03_L04
       xor       r14d,r14d
M03_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD344A6D48]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M03_L05
       test      rsi,rsi
       jne       near ptr M03_L06
M03_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M03_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M03_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD344B1640]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD3447A688
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34246640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD344A6DC0]
       test      rsi,rsi
       je        near ptr M03_L01
M03_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD344A6DC0]
       jmp       near ptr M03_L01
M03_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M03_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M03_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M03_L08
       mov       r11,7FFD33F412E8
       call      qword ptr [r11]
M03_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M03_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M03_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M03_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M03_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M03_L11
M03_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M03_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M03_L12
       mov       r11,7FFD33F412F0
       call      qword ptr [r11]
M03_L12:
       xor       eax,eax
       mov       [r14],rax
M03_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M03_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD3E3DB908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.TextJsonListMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,22EACC041A8
       mov       rdx,[rdx]
       mov       [rsp+50],rdx
       mov       rdx,22EACC04F48
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M00_L12
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L13
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L14
       mov       rdx,[rdi+0B8]
       mov       r8,22E80208830
       cmp       rdx,r8
       jne       near ptr M00_L14
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L07
M00_L02:
       lea       rdx,[rsp+50]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.MixedListTestObj ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.MixedListTestObj>)
       call      qword ptr [7FFD34496EC8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L08
       mov       rdx,22EACC04F48
       mov       r14,[rdx]
       test      r14,r14
       je        near ptr M00_L09
M00_L03:
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L10
M00_L04:
       mov       r15,[r14+10]
       test      r15,r15
       je        near ptr M00_L15
       mov       rdx,[r15+0B8]
       mov       r8,22E80208830
       cmp       rdx,r8
       jne       near ptr M00_L15
M00_L05:
       mov       rdx,r15
       mov       r8,rdx
       test      r8,r8
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L16
M00_L06:
       lea       rdx,[rbp+0C]
       mov       ecx,[rbp+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.MixedListTestObj, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.MixedListTestObj>)
       call      qword ptr [7FFD34674C60]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,22EACC041A8
       mov       rcx,[rcx]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+10]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+10]
       jne       short M00_L11
       inc       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FFD340743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L08:
       mov       ecx,389E
       mov       rdx,7FFD3446AA18
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3449C018]
       int       3
M00_L09:
       mov       rcx,22EACC04F48
       xor       edx,edx
       call      qword ptr [7FFD344959B0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FFD34495908]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L11:
       dec       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,22EACC04F48
       xor       edx,edx
       call      qword ptr [7FFD344959B0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       near ptr M00_L00
M00_L13:
       mov       rcx,rsi
       call      qword ptr [7FFD34495908]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L14:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,22E80208830
       mov       r8d,1
       call      qword ptr [7FFD344951B8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L15:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,22E80208830
       mov       r8d,1
       call      qword ptr [7FFD344951B8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFD340743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 659
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD34495980]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,22EACC01FF8
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFD34644BF0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,22E80201C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD34496C88]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       cmp       r15d,r12d
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFD3420E9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD3449D908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD3463F078]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFD3446C528
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22EACC04F88
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFD3463C5E8]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFD3463EB80]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFD3463C768]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFD3420E9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFD34125BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,22EACC01FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD34644BF8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1178
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,248
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+210],rax
       mov       [rbp],rsp
       mov       rax,0EC011B3D0A0E
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+28],rcx
       cmp       edi,55
       jle       near ptr M02_L11
       cmp       edi,15555555
       ja        short M02_L04
       mov       rdx,22EACC01FF8
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFD34644BF0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
M02_L01:
       test      rax,rax
       je        near ptr M02_L12
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M02_L02:
       mov       rax,r15
M02_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       jmp       short M02_L05
M02_L04:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FFD3449D950]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L01
M02_L05:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFD3449D968]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        short M02_L08
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L07
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L06
       jmp       short M02_L09
M02_L06:
       mov       ecx,347F
       mov       rdx,7FFD3446AA18
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3449C078]
       int       3
M02_L07:
       mov       ecx,347F
       mov       rdx,7FFD3446AA18
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3449C0C0]
       int       3
M02_L08:
       call      qword ptr [7FFD3420E9D0]
       int       3
M02_L09:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1E0],r10
       mov       [rbp+1E8],r10
       mov       byte ptr [rbp+1F0],0
       mov       byte ptr [rbp+1F1],0
       mov       byte ptr [rbp+1F2],0
       mov       byte ptr [rbp+1F3],0
       mov       byte ptr [rbp+1F4],0
       mov       byte ptr [rbp+1F5],0
       mov       [rbp+1F8],ecx
       mov       [rbp+1FC],r8b
       mov       [rbp+1FD],r9b
       mov       byte ptr [rbp+1FE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+200],xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       mov       [rbp+30],rdx
       mov       [rbp+38],eax
       lea       rdx,[rbp+30]
       lea       rcx,[rbp+120]
       lea       r9,[rbp+1E0]
       mov       r8d,1
       call      qword ptr [7FFD34675AD0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD34676B80]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34535938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rcx,[rbp+78]
       xor       edx,edx
       mov       [rbp+78],rdx
       mov       [rbp+20],rcx
       mov       rcx,[rbp]
       call      M02_L13
       nop
       mov       rax,[rbp+20]
       mov       rcx,0EC011B3D0A0E
       cmp       [rbp+8],rcx
       je        short M02_L10
       call      CORINFO_HELP_FAIL_FAST
M02_L10:
       nop
       lea       rsp,[rbp+218]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M02_L03
M02_L12:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M02_L02
M02_L13:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+28],0
       je        near ptr M02_L37
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M02_L15
       cmp       rdx,300
       ja        short M02_L14
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L15
M02_L14:
       mov       rdx,[rbp+70]
       call      qword ptr [7FFD34125BA8]
M02_L15:
       mov       rcx,22EACC01FF8
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFD33FB5120
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M02_L16
       mov       rcx,r14
       call      qword ptr [7FFD3463F108]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M02_L16:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M02_L32
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M02_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFD344CD2D8]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FFD33F24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFD3407F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L17:
       mov       edx,r13d
       shl       rdx,4
       lea       r15,[rcx+rdx+10]
       mov       rsi,[r15]
       mov       rdx,[rbp+28]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],eax
       test      rsi,rsi
       je        near ptr M02_L32
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M02_L19
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L18
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFD3463F090]
M02_L18:
       mov       rbx,[rax+8]
       mov       rcx,7FFD33FB5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD33FB5C38],0
       je        short M02_L20
       call      qword ptr [7FFD3407DC98]
       mov       edi,eax
       jmp       short M02_L23
M02_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L20:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       edi,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rdi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M02_L21
       call      qword ptr [7FFD346F5398]
       jmp       short M02_L22
M02_L21:
       mov       eax,edi
       sar       eax,10
M02_L22:
       mov       edi,eax
M02_L23:
       mov       rcx,7FFD33FB5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,edi
       xor       edx,edx
       div       dword ptr [7FFD33FB5C2C]
       mov       edi,edx
       xor       r15d,r15d
       jmp       near ptr M02_L30
M02_L24:
       cmp       edi,[rbx+8]
       jae       short M02_L19
       mov       ecx,edi
       mov       rax,[rbx+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+6C],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp+68],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L26
       test      r10d,r10d
       jne       short M02_L27
       xor       edx,edx
       mov       [rax+14],edx
M02_L25:
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M02_L26:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M02_L28
       mov       ecx,1
       jmp       short M02_L31
M02_L27:
       jmp       short M02_L25
M02_L28:
       inc       edi
       cmp       [rbx+8],edi
       jne       short M02_L29
       xor       edi,edi
M02_L29:
       inc       r15d
M02_L30:
       cmp       [rbx+8],r15d
       jg        near ptr M02_L24
       xor       ecx,ecx
M02_L31:
       mov       ebx,ecx
M02_L32:
       mov       rax,22EACC005D0
       mov       r15,[rax]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,esi
       mov       r9d,edi
       mov       edx,3
       call      qword ptr [7FFD34127678]
       test      ebx,r12d
       jne       short M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       esi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M02_L33
       mov       ecx,0FFFFFFFF
       jmp       short M02_L34
M02_L33:
       mov       ecx,r13d
M02_L34:
       mov       edx,ebx
       mov       r8d,esi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L35
       mov       eax,1
       jmp       short M02_L36
M02_L35:
       xor       eax,eax
M02_L36:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FFD3423E2B0]
M02_L37:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1600
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M03_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M03_L01
       test      r8,r8
       je        short M03_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M03_L01
       test      r8,r8
       je        short M03_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M03_L03
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       jmp       qword ptr [7FFD340743A8]
M03_L03:
       test      r8,r8
       je        short M03_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M03_L01
       test      r8,r8
       jne       short M03_L00
       jmp       short M03_L02
; Total bytes of code 71
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFD34495338]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFD34494390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFD344975E8]
       mov       [rbp-40],rax
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFD344974E0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M04_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34495398]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFD34497570]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M04_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M04_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M05_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFD34494390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M05_L05
       call      qword ptr [7FFD344974E0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD34074360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M05_L03
       jmp       near ptr M05_L09
M05_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L03:
       call      qword ptr [7FFD344976F0]
       test      eax,eax
       je        near ptr M05_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFD34534450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFD34534450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFD34534480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD344975B8]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M05_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34534318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34534318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34534318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD34495908]
       jmp       short M05_L09
M05_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34534390]
       jmp       short M05_L09
M05_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFD34074360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L07
M05_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M05_L08
M05_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M05_L08:
       cmp       dword ptr [rbp-34],0
       je        short M05_L09
       call      qword ptr [7FFD3449C978]
M05_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD344958C0]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M06_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34495170]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34534360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       cmp       qword ptr [rbp-8],0
       je        short M06_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD34496598]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M06_L01
M06_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD34495920]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M06_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M06_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD34334720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M06_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34495380]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD3449CF60]
M06_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.FerrisSingleMapping()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rcx,217D4C04198
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+58]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD33FB66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+68],0
       je        near ptr M00_L08
       cmp       dword ptr [rsp+68],1
       jne       near ptr M00_L09
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+60]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
M00_L00:
       mov       rdx,rsi
       call      qword ptr [7FFD34474030]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       test      rax,rax
       jne       short M00_L01
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L02
M00_L01:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
M00_L02:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       mov       rdx,21780308830
       lea       r8,[rsp+30]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD34474108]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M00_L10
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L10
       mov       rax,[rcx]
       add       rax,10
M00_L03:
       mov       r8,[rax+8]
       test      r8,r8
       jne       short M00_L04
       mov       r8,217D4C00438
       mov       r8,[r8]
       test      r8,r8
       jne       short M00_L04
       mov       r8,217D4C00418
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M00_L11
M00_L04:
       mov       rcx,[rsp+40]
       mov       rdx,21780308830
       call      qword ptr [7FFD344746F0]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       r8,rax
       test      r8,r8
       je        short M00_L05
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.StringPropertyObj
       cmp       [r8],rcx
       je        short M00_L05
       mov       rdx,rax
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L05:
       mov       rdx,217D4C04198
       mov       rdx,[rdx]
       mov       rcx,[rdx+8]
       mov       rdx,[r8+8]
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L06
       test      rdx,rdx
       je        short M00_L07
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L07
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD34115068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L07
M00_L06:
       inc       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       dec       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rdx,217D4C01F30
       mov       rcx,[rdx]
       jmp       near ptr M00_L00
M00_L09:
       lea       rdx,[rsp+58]
       mov       r8d,[rsp+68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD3422FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+68]
       mov       [rsp+6C],ecx
       mov       rcx,[rsp+58]
       jmp       near ptr M00_L00
M00_L10:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FFD341A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r8,rax
       jmp       near ptr M00_L04
; Total bytes of code 556
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       edi,r9d
       xor       r14d,r14d
       xor       r15d,r15d
       test      rbx,rbx
       je        near ptr M01_L03
       test      dil,1
       je        short M01_L00
       mov       rdx,rbx
       mov       rcx,217D4C00590
       mov       rcx,[rcx]
       call      qword ptr [7FFD345971E0]
       mov       rbx,rax
       mov       r15d,1
       mov       r13d,2
       jmp       short M01_L01
M01_L00:
       mov       r13d,1
M01_L01:
       cmp       byte ptr [rsp+0C8],0
       je        short M01_L04
       mov       ecx,[rbx+8]
       mov       eax,ecx
       cmp       word ptr [rbx+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rbx
       lea       r13d,[rcx-1]
       cmp       ecx,r13d
       jb        near ptr M01_L21
       test      r13d,r13d
       je        near ptr M01_L08
       cmp       ecx,r13d
       je        near ptr M01_L07
       mov       ecx,r13d
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       mov       r8d,r13d
       cmp       [rbx],bl
       lea       rcx,[rbx+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFD34115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r14d,1
M01_L03:
       xor       r13d,r13d
M01_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L09
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M01_L09
M01_L05:
       mov       rbp,rbx
       cmp       [r12],r12b
       lea       rax,[r12+60]
       mov       [rsp+30],rax
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rdx,rax
       test      rdx,rdx
       cmove     rdx,r12
M01_L06:
       mov       r12,rdx
       cmp       [r12],r12b
       cmp       r13d,1
       je        short M01_L10
       cmp       r13d,2
       je        short M01_L12
       jmp       near ptr M01_L14
M01_L07:
       mov       rbx,r12
       jmp       near ptr M01_L02
M01_L08:
       mov       rbx,21780300008
       jmp       near ptr M01_L02
M01_L09:
       mov       rcx,rbp
       call      qword ptr [7FFD33FB6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M01_L05
M01_L10:
       lea       rcx,[r12+20]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD34255050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L11
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFD34256838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L11:
       mov       r13,rax
       jmp       short M01_L16
M01_L12:
       lea       rcx,[r12+28]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD34255050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M01_L13
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFD34256838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M01_L13:
       jmp       short M01_L16
M01_L14:
       cmp       byte ptr [r12+18],0
       je        short M01_L15
       mov       r13,[r12+8]
       jmp       short M01_L16
M01_L15:
       mov       rcx,r12
       mov       r8d,r13d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFD34256838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M01_L16:
       xor       edi,2
       mov       ebp,[r13+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+40],r8
       mov       [rsp+48],r8
       mov       [rsp+50],r8d
       mov       [rsp+54],ecx
       xor       r12d,r12d
       test      ebp,ebp
       jle       short M01_L20
M01_L17:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       mov       [rsp+38],rax
       mov       ecx,[rax+58]
       mov       r8d,edi
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M01_L19
       test      r14d,r14d
       jne       short M01_L22
       cmp       qword ptr [rsp+0C0],0
       jne       near ptr M01_L23
M01_L18:
       lea       rcx,[rsp+40]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD34254FA8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L19:
       inc       r12d
       cmp       ebp,r12d
       jg        short M01_L17
M01_L20:
       mov       rdx,[rsp+40]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+50]
       mov       [rsi+10],eax
       mov       eax,[rsp+54]
       mov       [rsi+14],eax
       mov       rax,rsi
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rcx,r12
       mov       r8d,r13d
       xor       edx,edx
       call      qword ptr [7FFD34067258]
       int       3
M01_L22:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r8d,r15d
       call      qword ptr [7FFD33FB6538]
       test      eax,eax
       je        short M01_L19
       mov       rax,[rsp+38]
       mov       r10,[rsp+0C0]
       test      r10,r10
       mov       [rsp+0C0],r10
       je        near ptr M01_L18
M01_L23:
       mov       rcx,rax
       call      qword ptr [7FFD3430D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       mov       r10,[rsp+0C0]
       cmp       eax,[r10+8]
       mov       [rsp+0C0],r10
       jne       near ptr M01_L19
       mov       rax,[rsp+38]
       jmp       near ptr M01_L18
; Total bytes of code 835
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       vzeroupper
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-158],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M02_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp-1A0],rsp
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L86
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       [rbp-140],rdi
       mov       [rbp-148],rsi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L24
M02_L03:
       mov       ecx,[rbp-3C]
       mov       rcx,[rsi+rcx*8+10]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-150]
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rdx
       jne       near ptr M02_L89
       mov       rcx,[rbp-150]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L87
       test      rcx,rcx
       je        near ptr M02_L88
M02_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD34243270]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r14,rax
M02_L05:
       mov       rcx,[rbp-150]
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M02_L83
       mov       r15,[rbp-150]
       mov       rcx,[rbp-150]
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L32
M02_L06:
       mov       rcx,[r15+38]
       mov       r15,[rcx+18]
M02_L07:
       test      r14,r14
       je        near ptr M02_L30
       mov       rcx,21780300020
       cmp       r15,rcx
       jne       near ptr M02_L90
M02_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,217D4C01EE8
       mov       r13,[rcx]
       mov       rcx,r13
       mov       edx,100
       call      qword ptr [7FFD34239EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M02_L91
       lea       r12,[rax+10]
       mov       eax,[rax+8]
M02_L09:
       mov       [rbp-50],r12
       mov       [rbp-48],eax
       xor       edx,edx
       mov       [rbp-58],edx
       mov       byte ptr [rbp-54],0
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L92
       mov       rdx,21780308864
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-58]
       inc       edx
       mov       [rbp-58],edx
M02_L10:
       mov       rdx,[rbp-150]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdx],rcx
       jne       near ptr M02_L98
       mov       r15,[rbp-150]
       mov       rdx,[rbp-150]
       mov       r12,[rdx+8]
       test      r12,r12
       je        near ptr M02_L28
M02_L11:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L99
M02_L12:
       test      r12,r12
       je        near ptr M02_L99
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M02_L99
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD34115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rbp-58]
       add       edx,[r12+8]
       mov       [rbp-58],edx
M02_L13:
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L100
       mov       rdx,217803088CC
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rbp-58]
       add       edx,3
       mov       [rbp-58],edx
M02_L14:
       mov       [rbp-0D0],r14
       cmp       byte ptr [rbp-54],0
       jne       near ptr M02_L27
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD34064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L26
       xor       r8d,r8d
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D0]
       cmp       qword ptr [rbp-0D8],0
       jne       short M02_L15
       mov       r8,[r8]
       mov       [rbp-0D8],r8
       lea       r8,[rbp-0D8]
       cmp       qword ptr [rbp-0D8],0
       je        near ptr M02_L93
M02_L15:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L94
M02_L16:
       mov       r15,rcx
M02_L17:
       test      r15,r15
       je        short M02_L18
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M02_L78
       mov       rcx,[rbp-50]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L95
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD34115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-58]
       add       ecx,[r15+8]
       mov       [rbp-58],ecx
M02_L18:
       xor       ecx,ecx
       mov       [rbp-0D8],rcx
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L103
       mov       rcx,21780308864
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M02_L19:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rax,[rbp-50]
       mov       [rbp-138],rax
       mov       [rbp-130],ecx
       lea       rcx,[rbp-138]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r15,[rbp-60]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       test      r15,r15
       je        near ptr M02_L22
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFD33FA5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L96
M02_L20:
       xor       eax,eax
       mov       dword ptr [rbp-0E8],1
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       short M02_L21
       mov       dword ptr [rbp-0E4],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r15+8],edx
       jne       near ptr M02_L97
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rbp-178],r10
       mov       r9,[r10]
       mov       [rbp-180],r9
       mov       rcx,r10
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-178]
       mov       [rdx+8],ecx
       mov       rax,[rbp-180]
       test      rax,rax
       mov       [rbp-180],rax
       mov       eax,[rbp-0E4]
       jne       near ptr M02_L104
M02_L21:
       mov       rcx,217D4C005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L118
M02_L22:
       mov       rdx,r12
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L29
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L23:
       mov       edx,[rbp-3C]
       inc       edx
       mov       [rbp-3C],edx
       mov       edx,[rsi+8]
       cmp       edx,[rbp-3C]
       jg        near ptr M02_L03
M02_L24:
       mov       rdx,rdi
       mov       rcx,21780300C60
       call      qword ptr [7FFD34066DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M02_L84
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L84
       mov       ecx,[rbx+8]
       add       rcx,2
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L85
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       rcx,21780308AEC
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r14+0E]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFD34115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbx+8]
       inc       eax
       cdqe
       lea       rax,[r14+rax*2+0C]
       mov       rcx,21780308B04
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       rax,r14
M02_L25:
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L26:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD34064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L102
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD340643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rbp-68]
       mov       r11,7FFD33F20748
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L17
M02_L27:
       lea       rcx,[rbp-68]
       mov       r8,[rbp-0D0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD345BCD50]
       jmp       near ptr M02_L18
M02_L28:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0B8],xmm0
       mov       rdx,[r15+48]
       lea       rcx,[rbp-0B8]
       call      qword ptr [7FFD34256B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0B8]
       vmovups   [rbp-0C8],xmm0
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFD34256BE0]; System.MdUtf8String.ToString()
       mov       r12,rax
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L11
M02_L29:
       mov       rcx,rdi
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L30:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,21780308858
       mov       r8,21780308870
       call      qword ptr [7FFD34066B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L31
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L31:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L32:
       mov       rcx,[r15+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       r13,rax
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       [rbp-88],r13
       mov       [rbp-80],rax
       lea       rdx,[rbp-0A8]
       mov       [rsp+20],rdx
       mov       edx,[r15+50]
       lea       rcx,[rbp-88]
       lea       r8,[rbp-90]
       lea       r9,[rbp-98]
       call      qword ptr [7FFD342B5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       r13,[rbp-0A0]
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r9,[r15+30]
       mov       rcx,r12
       mov       rdx,r13
       mov       r8d,[rbp-0A8]
       call      qword ptr [7FFD34257B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r15+38]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L33:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD3411DF98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rbp-158],r14
       mov       rcx,[rbp-150]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFD34064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L42
       mov       rcx,rax
       mov       r11,7FFD33F20728
       call      qword ptr [r11]
       mov       [rbp-160],rax
       jmp       near ptr M02_L41
M02_L34:
       mov       rcx,[rbp-160]
       mov       r11,7FFD33F20738
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,21780300020
       cmp       rax,rcx
       je        short M02_L35
       mov       rcx,21780308898
       cmp       rax,rcx
       jne       near ptr M02_L37
M02_L35:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,21780308858
       mov       r8,21780308858
       call      qword ptr [7FFD34066B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,[rbp-158]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-158]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L36
       lea       r8d,[rdx+1]
       mov       r10,[rbp-158]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L41
M02_L36:
       mov       rcx,[rbp-158]
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L41
M02_L37:
       mov       rcx,rax
       call      qword ptr [7FFD33FB7330]; System.RuntimeType.GetBaseType()
       mov       rcx,217803021B8
       cmp       rax,rcx
       jne       short M02_L39
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,rax
       mov       edx,1C
       call      qword ptr [7FFD33FAA6C8]; System.RuntimeType.GetProperties(System.Reflection.BindingFlags)
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD34474030]
       mov       rcx,[rbp-158]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-158]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L38
       lea       r8d,[rdx+1]
       mov       r10,[rbp-158]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L41
M02_L38:
       mov       rcx,[rbp-158]
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L41
M02_L39:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,[rbp-158]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-158]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-158]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L40
       lea       r8d,[rdx+1]
       mov       r10,[rbp-158]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L41
M02_L40:
       mov       rcx,[rbp-158]
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L41:
       mov       rcx,[rbp-160]
       mov       r11,7FFD33F20730
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L34
       mov       rcx,rsp
       call      M02_L124
       nop
M02_L42:
       mov       rdx,[rbp-158]
       mov       rcx,21780300C60
       call      qword ptr [7FFD34066DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       r14,rbx
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-148]
       mov       rdi,[rbp-140]
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L43
       mov       rcx,21780308864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L44
M02_L43:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
M02_L44:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L45
       mov       rcx,21780308914
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L46
M02_L45:
       lea       rcx,[rbp-68]
       mov       rdx,21780308908
       call      qword ptr [7FFD341858F0]
M02_L46:
       lea       rcx,[rbp-68]
       mov       rdx,r14
       call      qword ptr [7FFD34185830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L47
       mov       rcx,21780308934
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L48
M02_L47:
       lea       rcx,[rbp-68]
       mov       rdx,21780308928
       call      qword ptr [7FFD341858F0]
M02_L48:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L49
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L49:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L50:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       mov       rcx,217803021B8
       cmp       rax,rcx
       jne       near ptr M02_L52
       mov       rcx,r15
       mov       edx,1C
       mov       rax,[r15]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       cmp       dword ptr [rax+8],0
       je        near ptr M02_L52
       mov       rcx,r15
       mov       edx,1C
       mov       rax,[r15]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD34474030]
       mov       r15,rax
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r15
       mov       rcx,21780308858
       mov       r8,21780308940
       call      qword ptr [7FFD34066B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L51
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L51:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L52:
       mov       rcx,21780308960
       cmp       r15,rcx
       je        near ptr M02_L53
       mov       rcx,21780308660
       cmp       r15,rcx
       je        near ptr M02_L53
       mov       rcx,21780304FC0
       cmp       r15,rcx
       je        near ptr M02_L53
       mov       rcx,21780308988
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,21780305F58
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,217803089B0
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,217803089D8
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,21780308A00
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,21780308A28
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,21780304B88
       cmp       r15,rcx
       je        short M02_L53
       mov       rcx,21780308A50
       cmp       r15,rcx
       jne       near ptr M02_L59
M02_L53:
       lea       rcx,[rbp-68]
       mov       edx,3
       mov       r8d,2
       call      qword ptr [7FFD341856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L54
       mov       rcx,21780308864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L55
M02_L54:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
M02_L55:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,2
       jb        short M02_L56
       mov       rcx,2178030894C
       mov       eax,[rcx]
       mov       [rdx],eax
       mov       ecx,[rbp-58]
       add       ecx,2
       mov       [rbp-58],ecx
       jmp       short M02_L57
M02_L56:
       lea       rcx,[rbp-68]
       mov       rdx,21780308940
       call      qword ptr [7FFD341858F0]
M02_L57:
       lea       rcx,[rbp-68]
       mov       r8,r14
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD342E6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L58
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L58:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L59:
       mov       rdx,21780308A78
       cmp       r15,rdx
       jne       near ptr M02_L61
       mov       rdx,r14
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFD34064408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovss    xmm0,dword ptr [rax]
       vmovss    dword ptr [rbp-6C],xmm0
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,217D4C00428
       mov       rcx,[rcx]
       vmovss    xmm0,dword ptr [rbp-6C]
       vmovss    dword ptr [rbp-110],xmm0
       call      qword ptr [7FFD3418F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovss    xmm0,dword ptr [rbp-110]
       mov       rdx,21780308AA0
       call      qword ptr [7FFD341AFA98]
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,21780308858
       mov       r8,21780308940
       call      qword ptr [7FFD34066B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L60
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L60:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L61:
       mov       rdx,21780305718
       cmp       r15,rdx
       jne       near ptr M02_L63
       mov       rdx,r14
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFD34064408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       vmovsd    xmm0,qword ptr [rax]
       vmovsd    qword ptr [rbp-78],xmm0
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,217D4C00428
       mov       rcx,[rcx]
       vmovsd    xmm0,qword ptr [rbp-78]
       vmovsd    qword ptr [rbp-118],xmm0
       call      qword ptr [7FFD3418F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovsd    xmm0,qword ptr [rbp-118]
       mov       rdx,21780308AA0
       call      qword ptr [7FFD341AFA38]; System.Number.FormatDouble(Double, System.String, System.Globalization.NumberFormatInfo)
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,21780308858
       mov       r8,21780308940
       call      qword ptr [7FFD34066B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L62
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L62:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L63:
       mov       rcx,21780303C30
       cmp       r15,rcx
       jne       near ptr M02_L65
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       cmp       [rax],al
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFD340672A0]
       mov       r9,rax
       mov       rdx,r15
       mov       rcx,21780308858
       mov       r8,21780308940
       call      qword ptr [7FFD34066B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L64
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L64:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L65:
       mov       rdx,21780308AB8
       cmp       r15,rdx
       jne       near ptr M02_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFD34064408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rcx,[rax]
       mov       r8,217D4C00428
       mov       r8,[r8]
       mov       rdx,21780306808
       call      qword ptr [7FFD345BEF10]
       mov       r14,rax
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L66
       mov       rcx,21780308864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L67
M02_L66:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
M02_L67:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L68
       mov       rcx,217803088CC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L69
M02_L68:
       lea       rcx,[rbp-68]
       mov       rdx,217803088C0
       call      qword ptr [7FFD341858F0]
M02_L69:
       lea       rcx,[rbp-68]
       mov       rdx,r14
       call      qword ptr [7FFD34185830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L70
       mov       rcx,21780308864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L71
M02_L70:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
M02_L71:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L72
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L72:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L73:
       lea       rcx,[rbp-68]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L74
       mov       rcx,21780308864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L75
M02_L74:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
M02_L75:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        short M02_L78
       mov       rdx,[rbp-50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L76
       mov       rcx,217803088CC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-58]
       add       ecx,3
       mov       [rbp-58],ecx
       jmp       short M02_L77
M02_L76:
       lea       rcx,[rbp-68]
       mov       rdx,217803088C0
       call      qword ptr [7FFD341858F0]
M02_L77:
       lea       rcx,[rbp-68]
       mov       r8,r14
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD342E6EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       r14d,[rbp-58]
       cmp       r14d,[rbp-48]
       jbe       short M02_L79
M02_L78:
       call      qword ptr [7FFD341FE9D0]
       int       3
M02_L79:
       mov       rcx,[rbp-50]
       mov       edx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,r14d
       cmp       edx,1
       jb        short M02_L80
       mov       rdx,21780308864
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
       jmp       short M02_L81
M02_L80:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
M02_L81:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L82
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L82:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3411E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L83:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r15,rax
       jmp       near ptr M02_L07
M02_L84:
       mov       rcx,21780308AE0
       mov       rdx,21780308AF8
       call      qword ptr [7FFD34066B08]; System.String.Concat(System.String, System.String)
       jmp       near ptr M02_L25
M02_L85:
       call      qword ptr [7FFD341FEF40]
       int       3
M02_L86:
       mov       rcx,217D4C01F00
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L87:
       xor       ecx,ecx
       test      rcx,rcx
       jne       near ptr M02_L04
M02_L88:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3459C048]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3406F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L89:
       mov       rcx,[rbp-150]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M02_L05
M02_L90:
       mov       rcx,21780308898
       cmp       r15,rcx
       je        near ptr M02_L08
       mov       rdx,r15
       mov       rcx,217803088E0
       call      qword ptr [7FFD33FAA7B0]; Precode of System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       je        near ptr M02_L50
       jmp       near ptr M02_L33
M02_L91:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M02_L09
M02_L92:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
       jmp       near ptr M02_L10
M02_L93:
       xor       r15d,r15d
       jmp       near ptr M02_L17
M02_L94:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L16
M02_L95:
       lea       rcx,[rbp-68]
       mov       rdx,r15
       call      qword ptr [7FFD341858F0]
       jmp       near ptr M02_L18
M02_L96:
       mov       rcx,r13
       call      qword ptr [7FFD3422D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L20
M02_L97:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFD3459E2C8]
       mov       r14,rax
       mov       ecx,1D3
       mov       rdx,7FFD33F14000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFD3406F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M02_L98:
       mov       rcx,[rbp-150]
       mov       rax,[rbp-150]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       cmp       byte ptr [rbp-54],0
       je        near ptr M02_L12
M02_L99:
       lea       rcx,[rbp-68]
       mov       rdx,r12
       call      qword ptr [7FFD34185848]
       jmp       near ptr M02_L13
M02_L100:
       lea       rcx,[rbp-68]
       mov       rdx,217803088C0
       call      qword ptr [7FFD341858F0]
       jmp       near ptr M02_L14
M02_L101:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFD34185938]
M02_L102:
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD340643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       edx,[rbp-58]
       cmp       edx,[rbp-48]
       ja        near ptr M02_L78
       mov       r9,[rbp-50]
       mov       r8d,edx
       lea       r9,[r9+r8*2]
       mov       r8d,[rbp-48]
       sub       r8d,edx
       xor       edx,edx
       mov       [rbp-128],r9
       mov       [rbp-120],r8d
       mov       [rbp-138],rdx
       xor       edx,edx
       mov       [rbp-130],edx
       mov       rdx,[rbp-68]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-128]
       lea       r9,[rbp-138]
       lea       r8,[rbp-0E0]
       mov       r11,7FFD33F20750
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L101
       mov       ecx,[rbp-58]
       add       ecx,[rbp-0E0]
       mov       [rbp-58],ecx
       jmp       near ptr M02_L18
M02_L103:
       lea       rcx,[rbp-68]
       mov       rdx,21780308858
       call      qword ptr [7FFD341858F0]
       jmp       near ptr M02_L19
M02_L104:
       mov       rcx,[r13+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L123
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rbp-0E4],eax
       jne       short M02_L105
       mov       rcx,r13
       mov       edx,r14d
       call      qword ptr [7FFD3422D7E8]
       mov       r10,rax
M02_L105:
       mov       r10,[r10+8]
       mov       [rbp-188],r10
       mov       rcx,7FFD33FA5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD33FA5C38],0
       je        short M02_L106
       call      qword ptr [7FFD3406DC98]
       mov       edx,eax
       mov       [rbp-100],edx
       jmp       short M02_L109
M02_L106:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-104],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-104]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L107
       call      qword ptr [7FFD345B6760]
       mov       edx,eax
       jmp       short M02_L108
M02_L107:
       mov       edx,ecx
       sar       edx,10
M02_L108:
       mov       [rbp-100],edx
M02_L109:
       mov       rcx,7FFD33FA5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-100]
       xor       edx,edx
       div       dword ptr [7FFD33FA5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L116
M02_L110:
       cmp       eax,[r8+8]
       jae       near ptr M02_L123
       mov       [rbp-0F8],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-190],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-108],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-190]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-10C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L112
       test      r10d,r10d
       jne       short M02_L113
       xor       edx,edx
       mov       [rax+14],edx
M02_L111:
       movsxd    rdx,r10d
       mov       r8,[rbp-180]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-10C]
       inc       ecx
       mov       rax,[rbp-190]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-108],1
M02_L112:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-108]
       test      ecx,ecx
       je        short M02_L114
       mov       r8d,1
       jmp       short M02_L117
M02_L113:
       jmp       short M02_L111
M02_L114:
       mov       eax,[rbp-0F8]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-188]
       cmp       [rcx+8],r8d
       jne       short M02_L115
       xor       r8d,r8d
M02_L115:
       mov       edx,[rbp-0FC]
       inc       edx
       mov       eax,r8d
M02_L116:
       mov       r8,[rbp-188]
       mov       [rbp-0FC],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L110
       xor       r8d,r8d
M02_L117:
       mov       eax,r8d
       mov       [rbp-0E8],eax
       mov       eax,[rbp-0E4]
       jmp       near ptr M02_L21
M02_L118:
       mov       rdx,r10
       mov       r8d,eax
       mov       eax,[rbp-0E8]
       cmp       dword ptr [r15+8],0
       mov       [rbp-168],rdx
       mov       [rbp-0E4],r8d
       mov       [rbp-0E8],eax
       je        near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0EC],eax
       mov       edx,[r15+8]
       mov       [rbp-0F0],edx
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-168]
       mov       r8d,[rbp-0EC]
       mov       r9d,[rbp-0F0]
       mov       edx,3
       call      qword ptr [7FFD34117678]
       mov       eax,[rbp-0E4]
       test      [rbp-0E8],eax
       mov       [rbp-0E4],eax
       jne       near ptr M02_L22
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rbp-168]
       mov       [rbp-170],rdx
       mov       [rbp-0F4],eax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[rbp-0E4]
       test      r13d,r13d
       jne       short M02_L119
       mov       r14,[rbp-170]
       mov       edx,[rbp-0F4]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L120
M02_L119:
       mov       rdx,[rbp-170]
       mov       ecx,[rbp-0F4]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M02_L120:
       mov       r8d,r15d
       mov       r9d,eax
       test      r13d,r13d
       jne       short M02_L121
       mov       eax,1
       jmp       short M02_L122
M02_L121:
       xor       eax,eax
M02_L122:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFD3422E2B0]
       jmp       near ptr M02_L22
M02_L123:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L124:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1D0]
       mov       rdx,[rbp-160]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD34064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L125
       mov       rcx,rax
       mov       r11,7FFD33F20740
       call      qword ptr [r11]
M02_L125:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 6680
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,288
       vzeroupper
       xor       eax,eax
       mov       [rsp+128],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M03_L01:
       vmovdqa   xmmword ptr [rsp+rax+280],xmm4
       vmovdqa   xmmword ptr [rsp+rax+290],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2A0],xmm4
       add       rax,30
       jne       short M03_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M03_L70
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+1E8]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFD33FB66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+1F8],0
       je        near ptr M03_L68
       cmp       dword ptr [rsp+1F8],1
       jne       near ptr M03_L69
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rsp+1F0]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M03_L02:
       mov       rcx,217D4C04E90
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M03_L17
M03_L03:
       mov       rcx,217D4C04E98
       mov       r9,[rcx]
       test      r9,r9
       je        short M03_L05
M03_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFD34476898]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       [rsp+120],rax
       cmp       [rbx],r14
       jne       near ptr M03_L77
       mov       rcx,rbx
       jmp       near ptr M03_L18
M03_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,217D4C04E88
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD34472700
       mov       [r12+18],rcx
       mov       rcx,217D4C04E98
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r12
       jmp       near ptr M03_L04
M03_L06:
       mov       r12d,1
       xor       ebx,ebx
       xor       eax,eax
       mov       [rsp+110],rax
       xor       r10d,r10d
       mov       [rsp+108],r10
       xor       r9d,r9d
       mov       [rsp+100],r9
M03_L07:
       mov       r11,rdi
       mov       r8d,ebp
       test      r8d,r8d
       je        near ptr M03_L80
       movzx     ecx,word ptr [r11]
       cmp       ecx,7B
       je        near ptr M03_L16
       cmp       ecx,7D
       je        near ptr M03_L15
       cmp       ecx,22
       jne       near ptr M03_L12
       cmp       r12d,9
       jne       short M03_L09
M03_L08:
       mov       edx,7
       jmp       short M03_L10
M03_L09:
       mov       edx,6
M03_L10:
       mov       ecx,edx
       mov       [rsp+1E4],ecx
       cmp       ecx,6
       je        short M03_L11
       cmp       ecx,7
       jne       near ptr M03_L23
M03_L11:
       cmp       ecx,6
       jne       near ptr M03_L19
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1B8],xmm0
       cmp       r8d,1
       jb        near ptr M03_L121
       add       r11,2
       sub       r8d,1
       mov       [rsp+58],r11
       mov       [rsp+14C],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD342E56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+1CC],eax
       cmp       eax,[rsp+14C]
       ja        near ptr M03_L121
       mov       rcx,[rsp+58]
       mov       [rsp+1B8],rcx
       mov       [rsp+1C0],eax
       lea       rcx,[rsp+1B8]
       call      qword ptr [7FFD3411C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+50],rax
       mov       edx,[rsp+1CC]
       add       edx,2
       mov       [rsp+148],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+90],rax
       mov       dword ptr [rax+10],6
       mov       edx,[rsp+148]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+90]
       jmp       near ptr M03_L21
M03_L12:
       cmp       ecx,3A
       jne       near ptr M03_L71
       mov       edx,9
       jmp       near ptr M03_L10
M03_L13:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       eax,[rsp+1E4]
       mov       [r8+10],eax
       mov       dword ptr [r8+14],1
       mov       byte ptr [r8+18],0
       mov       r10,r8
       mov       r8,r10
M03_L14:
       mov       rdx,r8
       mov       [rsp+0F8],rdx
       mov       r8d,[rdx+10]
       mov       [rsp+284],r8d
       mov       r11d,[rdx+14]
       mov       [rsp+280],r11d
       cmp       r8d,2
       je        near ptr M03_L67
       cmp       r8d,8
       je        near ptr M03_L24
       cmp       r8d,5
       jne       near ptr M03_L22
       mov       r8d,[rsp+284]
       jmp       near ptr M03_L24
M03_L15:
       mov       edx,5
       jmp       near ptr M03_L10
M03_L16:
       mov       edx,4
       jmp       near ptr M03_L10
M03_L17:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,217D4C04E88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD344726E8
       mov       [r13+18],rcx
       mov       rcx,217D4C04E90
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L03
M03_L18:
       test      rcx,rcx
       je        near ptr M03_L78
       cmp       [rcx],r14
       jne       near ptr M03_L78
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FB6E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M03_L79
       jmp       near ptr M03_L06
M03_L19:
       cmp       ecx,7
       jne       near ptr M03_L86
       test      r8d,r8d
       je        near ptr M03_L122
       movzx     ecx,word ptr [r11]
       cmp       ecx,22
       jne       near ptr M03_L85
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1A0],xmm0
       cmp       r8d,1
       jb        near ptr M03_L121
       add       r11,2
       sub       r8d,1
       mov       [rsp+48],r11
       mov       [rsp+144],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD342E56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jle       short M03_L20
       lea       ecx,[rax-1]
       mov       edx,[rsp+144]
       cmp       ecx,edx
       jae       near ptr M03_L122
       lea       ecx,[rax-1]
       mov       r11,[rsp+48]
       cmp       word ptr [r11+rcx*2],5C
       je        near ptr M03_L81
M03_L20:
       cmp       eax,[rsp+144]
       ja        near ptr M03_L121
       mov       r11,[rsp+48]
       mov       [rsp+1B4],eax
       mov       ecx,eax
       mov       [rsp+1A0],r11
       mov       [rsp+1A8],ecx
       lea       rcx,[rsp+1A0]
       call      qword ptr [7FFD3411C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+40],rax
       mov       edx,[rsp+1B4]
       add       edx,2
       mov       [rsp+140],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       dword ptr [rax+10],7
       mov       edx,[rsp+140]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
M03_L21:
       mov       r8,rax
       jmp       near ptr M03_L14
M03_L22:
       mov       r8d,[rsp+284]
       cmp       r8d,4
       jne       near ptr M03_L62
       jmp       near ptr M03_L66
M03_L23:
       cmp       ecx,3
       je        near ptr M03_L87
       jmp       near ptr M03_L13
M03_L24:
       cmp       r12d,7
       jne       near ptr M03_L50
       mov       rax,[rsp+110]
       test      rax,rax
       je        near ptr M03_L49
       cmp       dword ptr [rax+10],6
       jne       near ptr M03_L48
       mov       [rsp+110],rax
       mov       rcx,[rax+8]
       mov       [rsp+30],rcx
       test      rcx,rcx
       je        near ptr M03_L47
       mov       r10,[rsp+108]
       test      r10,r10
       je        near ptr M03_L46
       mov       [rsp+108],r10
       cmp       dword ptr [r10+10],9
       jne       near ptr M03_L45
       mov       r9,[rsp+100]
       test      r9,r9
       je        near ptr M03_L44
       cmp       dword ptr [r9+10],7
       jne       near ptr M03_L43
       mov       [rsp+100],r9
       movzx     ecx,byte ptr [r9+18]
M03_L25:
       test      ecx,ecx
       je        near ptr M03_L42
       mov       rcx,[rsp+30]
       mov       [rsp+0B0],rcx
       mov       r15,rcx
       test      r15,r15
       je        near ptr M03_L41
       mov       r10,offset MT_System.String
       cmp       [r15],r10
       jne       near ptr M03_L115
M03_L26:
       mov       rcx,[rsp+120]
       cmp       [rcx],cl
       mov       rdx,r15
       call      qword ptr [7FFD3406EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M03_L22
       mov       r15,[rax]
       mov       rax,[rsp+100]
       cmp       byte ptr [rax+18],0
       je        near ptr M03_L40
       mov       [rsp+100],rax
       mov       rdx,[rax+8]
       mov       [rsp+88],rdx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r15],rcx
       jne       near ptr M03_L91
       mov       rcx,r15
       cmp       qword ptr [rcx+38],0
       je        near ptr M03_L56
M03_L27:
       mov       rcx,[r15+38]
       mov       r10,[rcx+18]
M03_L28:
       mov       r9,r10
       mov       [rsp+80],r9
       mov       rcx,21780300020
       cmp       r9,rcx
       jne       near ptr M03_L89
M03_L29:
       mov       rcx,offset MT_System.String
       mov       rdx,[rsp+88]
       cmp       [rdx],rcx
       jne       near ptr M03_L92
       mov       rcx,rdx
M03_L30:
       test      rcx,rcx
       je        short M03_L31
       mov       rdx,21780308B38
       xor       r8d,r8d
       call      qword ptr [7FFD340662F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M03_L90
M03_L31:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r15],rcx
       jne       near ptr M03_L96
       cmp       qword ptr [r15+20],0
       je        near ptr M03_L93
       mov       r15,[r15+20]
M03_L32:
       test      r15,r15
       je        near ptr M03_L116
       cmp       qword ptr [r15+48],0
       je        near ptr M03_L55
M03_L33:
       mov       rcx,[r15+48]
       test      dword ptr [rcx+3C],102
       je        short M03_L34
       mov       rcx,r15
       call      qword ptr [7FFD342558F0]
M03_L34:
       test      byte ptr [r15+5C],10
       jne       short M03_L37
       mov       rcx,[r15+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M03_L94
       mov       rcx,[r15+38]
       cmp       [rcx],r14
       jne       near ptr M03_L95
M03_L35:
       mov       rdx,r13
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
M03_L36:
       test      eax,eax
       je        near ptr M03_L117
M03_L37:
       mov       rax,[r15+30]
       test      rax,rax
       je        near ptr M03_L54
M03_L38:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M03_L118
       cmp       qword ptr [r15+48],0
       je        near ptr M03_L52
M03_L39:
       mov       rax,[rsp+88]
       mov       [rsp+20],rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[r15+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD342579C0]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       jmp       near ptr M03_L22
M03_L40:
       mov       [rsp+100],rax
       jmp       near ptr M03_L22
M03_L41:
       jmp       near ptr M03_L26
M03_L42:
       jmp       near ptr M03_L22
M03_L43:
       mov       [rsp+118],rbx
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       jmp       near ptr M03_L88
M03_L44:
       mov       [rsp+118],rbx
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       jmp       near ptr M03_L88
M03_L45:
       jmp       near ptr M03_L22
M03_L46:
       mov       [rsp+108],r10
       jmp       near ptr M03_L22
M03_L47:
       jmp       near ptr M03_L22
M03_L48:
       mov       [rsp+110],rax
       jmp       near ptr M03_L22
M03_L49:
       mov       [rsp+110],rax
       jmp       near ptr M03_L22
M03_L50:
       jmp       near ptr M03_L22
M03_L51:
       cmp       r8d,5
       je        near ptr M03_L65
       jmp       short M03_L53
M03_L52:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFD342578A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[r15+48]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L39
M03_L53:
       cmp       r8d,8
       je        near ptr M03_L59
       jmp       near ptr M03_L57
M03_L54:
       mov       rcx,r15
       call      qword ptr [7FFD34255920]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M03_L38
M03_L55:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+68],rax
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFD342578A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[r15+48]
       mov       rdx,[rsp+68]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L33
M03_L56:
       mov       rcx,[r15+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+70],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+70]
       mov       [rsp+178],rdx
       mov       [rsp+180],rax
       lea       rdx,[rsp+158]
       mov       [rsp+20],rdx
       mov       edx,[r15+50]
       lea       rcx,[rsp+178]
       lea       r8,[rsp+170]
       lea       r9,[rsp+168]
       call      qword ptr [7FFD342B5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+160]
       mov       [rsp+150],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+78],rax
       mov       r9,[r15+30]
       mov       rcx,rax
       mov       rdx,[rsp+150]
       mov       r8d,[rsp+158]
       call      qword ptr [7FFD34257B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r15+38]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L27
M03_L57:
       cmp       r8d,3
       je        short M03_L59
       cmp       r8d,6
       jne       short M03_L61
       jmp       near ptr M03_L64
M03_L58:
       cmp       r8d,4
       jne       short M03_L59
       test      rbx,rbx
       jne       short M03_L59
       mov       rdx,[rsp+0F8]
       mov       rbx,rdx
M03_L59:
       cmp       r8d,3
       je        short M03_L60
       mov       r12d,r8d
M03_L60:
       mov       r11d,[rsp+280]
       cmp       r11d,ebp
       ja        near ptr M03_L121
       mov       r8d,r11d
       lea       rdi,[rdi+r8*2]
       sub       ebp,r11d
       jmp       near ptr M03_L07
M03_L61:
       cmp       r8d,9
       je        short M03_L63
       cmp       r8d,7
       jne       short M03_L58
       mov       rdx,[rsp+0F8]
       mov       r9,rdx
       mov       [rsp+100],r9
       jmp       short M03_L59
M03_L62:
       cmp       r8d,0A
       je        near ptr M03_L102
       jmp       near ptr M03_L51
M03_L63:
       mov       rdx,[rsp+0F8]
       mov       r10,rdx
       mov       [rsp+108],r10
       jmp       short M03_L59
M03_L64:
       mov       rdx,[rsp+0F8]
       mov       rax,rdx
       mov       [rsp+110],rax
       jmp       near ptr M03_L59
M03_L65:
       mov       r11d,[rsp+280]
       cmp       r11d,ebp
       ja        near ptr M03_L121
       mov       r8d,r11d
       lea       rdi,[rdi+r8*2]
       sub       ebp,r11d
       jmp       short M03_L67
M03_L66:
       cmp       r12d,9
       je        near ptr M03_L97
       jmp       short M03_L62
M03_L67:
       mov       rcx,rsi
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,288
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L68:
       mov       rdx,217D4C01F30
       mov       r15,[rdx]
       jmp       near ptr M03_L02
M03_L69:
       lea       rdx,[rsp+1E8]
       mov       r8d,[rsp+1F8]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFD3422FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+1F8]
       mov       [rsp+1FC],ecx
       mov       r15,[rsp+1E8]
       jmp       near ptr M03_L02
M03_L70:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M03_L02
M03_L71:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       cmp       ecx,2C
       jne       short M03_L72
       mov       edx,8
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L10
M03_L72:
       cmp       ecx,5B
       jne       short M03_L73
       mov       edx,0A
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L10
M03_L73:
       cmp       ecx,5D
       jne       short M03_L74
       mov       edx,0B
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L10
M03_L74:
       cmp       ecx,20
       jne       short M03_L75
       mov       edx,3
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L10
M03_L75:
       cmp       r12d,9
       je        short M03_L76
       xor       edx,edx
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L10
M03_L76:
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L08
M03_L77:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M03_L18
M03_L78:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD3459C660]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFD33F14000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFD3406F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L79:
       mov       [rsp+208],rdi
       mov       [rsp+210],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+200]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+210]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,288
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L80:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       mov       edx,2
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L10
M03_L81:
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       mov       r11d,eax
       mov       r8,[rsp+48]
       mov       [rsp+38],r8
       mov       edx,[rsp+144]
       mov       [rsp+13C],edx
       jmp       short M03_L83
M03_L82:
       lea       ecx,[rax+1]
       cmp       ecx,[rsp+13C]
       mov       [rsp+108],r10
       ja        near ptr M03_L121
       mov       eax,ecx
       mov       r11,[rsp+38]
       lea       r11,[r11+rax*2]
       mov       eax,[rsp+13C]
       sub       eax,ecx
       mov       edx,22
       mov       [rsp+38],r11
       mov       rcx,r11
       mov       [rsp+13C],eax
       mov       r8d,eax
       call      qword ptr [7FFD342E56C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       edx,eax
       mov       ecx,[rsp+19C]
       lea       ecx,[rcx+rdx+1]
       mov       eax,edx
       mov       r11d,ecx
       mov       edx,[rsp+144]
       mov       r8,[rsp+48]
       mov       r10,[rsp+108]
M03_L83:
       test      eax,eax
       jle       short M03_L84
       lea       ecx,[r11-1]
       cmp       ecx,edx
       jae       near ptr M03_L122
       mov       [rsp+19C],r11d
       lea       ecx,[r11-1]
       cmp       word ptr [r8+rcx*2],5C
       je        near ptr M03_L82
       mov       edx,[rsp+144]
       mov       r8,[rsp+48]
       mov       r11d,[rsp+19C]
M03_L84:
       mov       ecx,r11d
       mov       [rsp+108],r10
       mov       eax,ecx
       jmp       near ptr M03_L20
M03_L85:
       mov       r15,[rsp+120]
       mov       [rsp+128],r11
       mov       [rsp+130],r8d
       lea       rdx,[rsp+128]
       lea       rcx,[rsp+1D0]
       call      qword ptr [7FFD34474198]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       rcx,rax
       mov       edx,7
       mov       r8d,[rsp+1D8]
       call      qword ptr [7FFD34476628]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+1D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       jmp       near ptr M03_L21
M03_L86:
       mov       r15,[rsp+120]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsp+1E4]
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       jmp       near ptr M03_L21
M03_L87:
       mov       r15,[rsp+120]
       mov       [rsp+128],r11
       mov       [rsp+130],r8d
       lea       rcx,[rsp+128]
       call      qword ptr [7FFD34474150]
       mov       [rsp+1E0],eax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r10,rax
       mov       [rsp+0A8],r10
       mov       rcx,r10
       mov       edx,3
       mov       r8d,[rsp+1E0]
       call      qword ptr [7FFD34476628]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       r10,[rsp+0A8]
       mov       rcx,r10
       mov       r8,rcx
       jmp       near ptr M03_L14
M03_L88:
       xor       ebx,ebx
       mov       [rsp+100],r9
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       mov       ecx,ebx
       mov       rbx,[rsp+118]
       jmp       near ptr M03_L25
M03_L89:
       mov       rcx,r9
       mov       r8,[r9]
       mov       r8,[r8+98]
       call      qword ptr [r8+20]
       mov       rcx,217803021B8
       cmp       rax,rcx
       je        near ptr M03_L29
       mov       r9,[rsp+80]
       mov       rcx,r9
       mov       r8,[r9]
       mov       r8,[r8+58]
       call      qword ptr [r8+10]
       test      eax,eax
       jne       near ptr M03_L29
       mov       r9,[rsp+80]
       lea       rcx,[rsp+188]
       mov       rdx,r9
       mov       r8,[rsp+88]
       call      qword ptr [7FFD34476868]
       mov       rcx,r15
       mov       rdx,r13
       mov       r8,[rsp+188]
       xor       r9d,r9d
       mov       rax,[r15]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L22
M03_L90:
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       xor       r9d,r9d
       mov       r10,[r15]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       jmp       near ptr M03_L22
M03_L91:
       mov       rcx,r15
       mov       r9,[r15]
       mov       r9,[r9+50]
       call      qword ptr [r9+10]
       mov       rcx,rax
       mov       r10,rcx
       jmp       near ptr M03_L28
M03_L92:
       mov       rcx,rdx
       mov       r8,[rdx]
       mov       r8,[r8+40]
       call      qword ptr [r8+8]
       mov       rcx,rax
       jmp       near ptr M03_L30
M03_L93:
       xor       r15d,r15d
       jmp       near ptr M03_L32
M03_L94:
       xor       ecx,ecx
       cmp       [rcx],r14
       je        near ptr M03_L35
M03_L95:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       jmp       near ptr M03_L36
M03_L96:
       mov       rcx,r15
       mov       rdx,r13
       mov       r8,[rsp+88]
       xor       r9d,r9d
       mov       r10,[r15]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       jmp       near ptr M03_L22
M03_L97:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       mov       [rsp+110],rax
       mov       rcx,rax
       mov       [rsp+108],r10
       mov       rdx,r10
       call      qword ptr [7FFD344740C0]
       test      eax,eax
       mov       r8d,[rsp+284]
       je        near ptr M03_L101
       mov       r10,[rsp+108]
       mov       rax,[rsp+110]
       mov       rdx,[rax+8]
       mov       [rsp+0C0],rdx
       mov       rcx,rdx
       mov       [rsp+0B8],rcx
       test      rcx,rcx
       je        near ptr M03_L100
       mov       rax,[rsp+110]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jne       near ptr M03_L119
M03_L98:
       lea       r8,[rsp+278]
       mov       rcx,r15
       mov       rdx,[rsp+0B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD340F4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       mov       r8d,[rsp+284]
       je        near ptr M03_L99
       mov       rcx,[rsp+278]
       mov       rdx,[rsp+278]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rdx,rax
       mov       [rsp+128],rdi
       mov       [rsp+130],ebp
       lea       r8,[rsp+128]
       lea       rcx,[rsp+260]
       call      qword ptr [7FFD34474108]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+260]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+100],r12
       mov       ebp,7
       mov       rdi,[rsp+268]
       mov       ecx,[rsp+270]
       mov       eax,ecx
       mov       r12d,ebp
       mov       ebp,eax
       jmp       near ptr M03_L07
M03_L99:
       jmp       near ptr M03_L59
M03_L100:
       mov       [rsp+108],r10
       jmp       near ptr M03_L98
M03_L101:
       jmp       near ptr M03_L59
M03_L102:
       mov       rax,[rsp+110]
       mov       r10,[rsp+108]
       mov       r15,[rsp+120]
       cmp       r12d,9
       jne       near ptr M03_L110
       mov       [rsp+110],rax
       mov       rcx,rax
       mov       [rsp+108],r10
       mov       rdx,r10
       call      qword ptr [7FFD344740C0]
       test      eax,eax
       mov       r8d,[rsp+284]
       je        near ptr M03_L109
       mov       rax,[rsp+110]
       mov       rdx,[rax+8]
       mov       rcx,rdx
       mov       [rsp+0D8],rcx
       test      rcx,rcx
       je        near ptr M03_L108
       mov       r11,offset MT_System.String
       cmp       [rcx],r11
       jne       near ptr M03_L120
M03_L103:
       lea       r8,[rsp+258]
       mov       rcx,r15
       mov       rdx,[rsp+0D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFD340F4630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L107
       mov       rcx,[rsp+258]
       mov       rdx,[rsp+258]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       [rsp+0F0],rax
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+60]
       call      qword ptr [rdx+8]
       test      eax,eax
       je        near ptr M03_L111
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       rcx,21780308B10
       cmp       rax,rcx
       jne       near ptr M03_L111
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L122
       mov       r12,[rax+10]
       mov       rcx,[rsp+0F0]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD34226028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD340643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0E8],rax
M03_L104:
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       lea       edx,[rbp-1]
       mov       [rsp+128],rdi
       mov       [rsp+130],edx
       mov       rdx,r12
       lea       r8,[rsp+128]
       lea       rcx,[rsp+238]
       call      qword ptr [7FFD344740F0]
       mov       rdi,[rsp+240]
       mov       ebp,[rsp+248]
       mov       [rsp+128],rdi
       mov       [rsp+130],ebp
       lea       rdx,[rsp+128]
       mov       ecx,1
       call      qword ptr [7FFD344741C8]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+254],eax
       mov       rcx,[rsp+0E8]
       mov       rdx,[rsp+238]
       mov       r11,7FFD33F20690
       call      qword ptr [r11]
       mov       ecx,[rsp+254]
       cmp       ecx,8
       je        near ptr M03_L104
       cmp       ecx,0B
       jne       short M03_L105
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       dec       ebp
M03_L105:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+10],7
       xor       ecx,ecx
       mov       [r12+14],ecx
       mov       byte ptr [r12+18],0
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+0E8]
       call      CORINFO_HELP_ASSIGN_REF
M03_L106:
       mov       eax,7
       mov       [rsp+100],r12
       mov       r12d,eax
       jmp       near ptr M03_L07
M03_L107:
       mov       r8d,[rsp+284]
       jmp       near ptr M03_L59
M03_L108:
       jmp       near ptr M03_L103
M03_L109:
       jmp       near ptr M03_L59
M03_L110:
       mov       [rsp+110],rax
       mov       [rsp+108],r10
       jmp       near ptr M03_L51
M03_L111:
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M03_L114
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r12,rax
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0D0],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+0D0]
       mov       rcx,21780308B10
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FAA758]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD34226028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD340643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+0E0],rax
M03_L112:
       cmp       ebp,1
       jb        near ptr M03_L121
       lea       rdx,[rdi+2]
       lea       r8d,[rbp-1]
       mov       [rsp+128],rdx
       mov       [rsp+130],r8d
       mov       rdx,r12
       lea       r8,[rsp+128]
       lea       rcx,[rsp+218]
       call      qword ptr [7FFD34474108]
       mov       rdi,[rsp+220]
       mov       ebp,[rsp+228]
       mov       [rsp+128],rdi
       mov       [rsp+130],ebp
       lea       rdx,[rsp+128]
       mov       ecx,1
       call      qword ptr [7FFD344741C8]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+234],eax
       mov       rcx,[rsp+0E0]
       mov       rdx,[rsp+218]
       mov       r11,7FFD33F20678
       call      qword ptr [r11]
       mov       ecx,[rsp+234]
       cmp       ecx,8
       je        near ptr M03_L112
       mov       rax,[rsp+0E0]
       cmp       ecx,0B
       jne       short M03_L113
       cmp       ebp,1
       jb        near ptr M03_L121
       add       rdi,2
       dec       ebp
M03_L113:
       mov       rcx,rax
       mov       r11,7FFD33F20680
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FFD33FB7678]; System.Array.CreateInstance(System.Type, Int32)
       mov       r12,rax
       mov       rcx,[rsp+0E0]
       mov       rdx,r12
       mov       r11,7FFD33F20688
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       dword ptr [rax+10],7
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+0C8]
       jmp       near ptr M03_L106
M03_L114:
       mov       rcx,[rsp+0F0]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r8d,[rsp+284]
       jmp       near ptr M03_L59
M03_L115:
       mov       rcx,r10
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L116:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3459CB70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3406F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L117:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD345B5188]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD34325998]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L118:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD3459C990]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34325908]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L119:
       mov       rcx,rdx
       mov       rdx,[rsp+0C0]
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L120:
       mov       rcx,r11
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L121:
       call      qword ptr [7FFD341FE9D0]
       int       3
M03_L122:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 5781
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFD34064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M04_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M04_L05
M04_L00:
       mov       rax,rbx
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       ecx,1D4F
       mov       rdx,7FFD33F14000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD342266E8]
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M04_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD3459FA50]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD34476F28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD3459FAE0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD34476F28]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L06:
       mov       rcx,21780303C30
       cmp       rsi,rcx
       jne       short M04_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F20720
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,21780308898
       cmp       rsi,rcx
       jne       short M04_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F20718
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L08:
       mov       rcx,21780308A00
       cmp       rsi,rcx
       jne       short M04_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F20710
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L09:
       mov       rcx,217803089D8
       cmp       rsi,rcx
       jne       short M04_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F20708
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,21780308960
       cmp       rsi,rcx
       jne       short M04_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F20700
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L11:
       mov       rcx,21780308660
       cmp       rsi,rcx
       jne       short M04_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206F8
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L12:
       mov       rcx,21780304FC0
       cmp       rsi,rcx
       jne       short M04_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206F0
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,21780308988
       cmp       rsi,rcx
       jne       short M04_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206E8
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L14:
       mov       rcx,21780305F58
       cmp       rsi,rcx
       jne       short M04_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206E0
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L15:
       mov       rcx,217803089B0
       cmp       rsi,rcx
       jne       short M04_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206D8
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L16:
       mov       rcx,21780308A78
       cmp       rsi,rcx
       jne       short M04_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206D0
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L17:
       mov       rcx,21780305718
       cmp       rsi,rcx
       jne       short M04_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206C8
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L18:
       mov       rcx,21780308A28
       cmp       rsi,rcx
       jne       short M04_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFD33F206C0
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L19:
       mov       rcx,21780308AB8
       cmp       rsi,rcx
       jne       short M04_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206B8
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L20:
       mov       rcx,21780300020
       cmp       rsi,rcx
       jne       short M04_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F206B0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M04_L21:
       mov       rcx,217803021B8
       cmp       rsi,rcx
       je        near ptr M04_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFD33F206A8
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M05_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M05_L02
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       jne       short M05_L00
M05_L03:
       jmp       qword ptr [7FFD340643A8]
; Total bytes of code 69
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M06_L03
       cmp       r8,4
       jae       short M06_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L00:
       test      r8b,1
       je        short M06_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M06_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L03:
       cmp       rcx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L04:
       vzeroupper
       ret
M06_L05:
       mov       eax,1
       vzeroupper
       ret
M06_L06:
       cmp       r8,20
       jb        short M06_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L08
M06_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L13
       add       rax,20
       cmp       r8,rax
       ja        short M06_L07
M06_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M06_L13
       nop       dword ptr [rax]
       jmp       short M06_L05
       nop       dword ptr [rax]
M06_L09:
       cmp       r8,10
       jb        short M06_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L11
M06_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M06_L13
       add       rax,10
       cmp       r8,rax
       ja        short M06_L10
M06_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M06_L13
       jmp       near ptr M06_L05
M06_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L04
M06_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M07_L05
       mov       rbp,[rdi]
       test      rbp,rbp
       je        near ptr M07_L06
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        near ptr M07_L04
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rsi
       mov       rdx,7FFD346F9630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       r13,[r15+10]
       add       rbp,10
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M07_L02
       jmp       short M07_L03
M07_L02:
       mov       rcx,rsi
       mov       rdx,7FFD346F9638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L03:
       mov       r9d,ebx
       mov       rdx,r13
       mov       r8,rbp
       call      qword ptr [7FFD34325308]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M07_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD341FED48]
       int       3
M07_L06:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L07
       jmp       short M07_L08
M07_L07:
       mov       rcx,rsi
       mov       rdx,7FFD346F9630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L08:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
; Total bytes of code 289
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFD3E3C41F8]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFD3E3D7B80]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD3E3D8B78]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.Object.GetType()

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.NewtonsoftSingleMapping()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,1F5E7004198
       mov       rsi,[rcx]
       mov       rcx,1F5E7004E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M00_L07
       xor       edi,edi
M00_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFD344B6D78]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rdi,rdi
       jne       near ptr M00_L08
M00_L01:
       mov       rcx,rsi
       mov       r8,rbp
       xor       edx,edx
       call      qword ptr [7FFD344B4420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       rdx,1F580309120
       xor       r8d,r8d
       call      qword ptr [7FFD344B4510]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.StringPropertyObj
       cmp       [rdi],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFD340943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       mov       r8,1F5E7004198
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rdi,rdi
       je        short M00_L05
       mov       rdx,[rdi+8]
M00_L03:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L04
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD34145068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L06
M00_L04:
       inc       dword ptr [rbx+8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       xor       edx,edx
       jmp       short M00_L03
M00_L06:
       dec       dword ptr [rbx+8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFD344B6DF0]
       jmp       near ptr M00_L01
; Total bytes of code 284
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,1F5E7004ED0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,1F5E70050C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F5E7004ED8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F5E70050B0
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1F5E7000428
       mov       r13,[rcx]
       mov       rcx,1F5E70014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F580301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,1F5E7005078
       mov       rax,1F5E7005080
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD3448A9D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3414D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD342D99F0]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD344BF540]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD33F50F18
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       rcx,1F5E7004E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M03_L04
       xor       r14d,r14d
M03_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD344B6D78]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M03_L05
       test      rsi,rsi
       jne       near ptr M03_L06
M03_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M03_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M03_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD344C19C0]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD3448A9D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34256640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD344B6DF0]
       test      rsi,rsi
       je        near ptr M03_L01
M03_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD344B6DF0]
       jmp       near ptr M03_L01
M03_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M03_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M03_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M03_L08
       mov       r11,7FFD33F510F8
       call      qword ptr [r11]
M03_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M03_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M03_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M03_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M03_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M03_L11
M03_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M03_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M03_L12
       mov       r11,7FFD33F51100
       call      qword ptr [r11]
M03_L12:
       xor       eax,eax
       mov       [r14],rax
M03_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M03_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD3E3DB908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M05_L03
       cmp       r8,4
       jae       short M05_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L00:
       test      r8b,1
       je        short M05_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M05_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L03:
       cmp       rcx,rdx
       je        short M05_L05
       jmp       short M05_L06
M05_L04:
       vzeroupper
       ret
M05_L05:
       mov       eax,1
       vzeroupper
       ret
M05_L06:
       cmp       r8,20
       jb        short M05_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L08
M05_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L13
       add       rax,20
       cmp       r8,rax
       ja        short M05_L07
M05_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L13
       nop       dword ptr [rax]
       jmp       short M05_L05
       nop       dword ptr [rax]
M05_L09:
       cmp       r8,10
       jb        short M05_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L11
M05_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L13
       add       rax,10
       cmp       r8,rax
       ja        short M05_L10
M05_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M05_L13
       jmp       near ptr M05_L05
M05_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M05_L04
M05_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.STJSingleMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,18745804198
       mov       rdx,[rdx]
       mov       [rsp+50],rdx
       mov       rdx,18745804F48
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L16
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L17
       mov       rdx,[rdi+0B8]
       mov       r8,18700208830
       cmp       rdx,r8
       jne       near ptr M00_L17
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L10
M00_L02:
       lea       rdx,[rsp+50]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.StringPropertyObj ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.StringPropertyObj>)
       call      qword ptr [7FFD34486EF8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rdx,18745804F48
       mov       r14,[rdx]
       test      r14,r14
       je        near ptr M00_L12
M00_L03:
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L13
M00_L04:
       mov       r15,[r14+10]
       test      r15,r15
       je        near ptr M00_L18
       mov       rdx,[r15+0B8]
       mov       r8,18700208830
       cmp       rdx,r8
       jne       near ptr M00_L18
M00_L05:
       mov       rdx,r15
       mov       r8,rdx
       test      r8,r8
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L19
M00_L06:
       lea       rdx,[rbp+0C]
       mov       ecx,[rbp+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.StringPropertyObj>)
       call      qword ptr [7FFD345FC6D8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       r8,18745804198
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rax,rax
       je        short M00_L09
       mov       rdx,[rax+8]
M00_L07:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L08
       test      rdx,rdx
       je        near ptr M00_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L14
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD34115068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L14
M00_L08:
       inc       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       xor       edx,edx
       jmp       short M00_L07
M00_L10:
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L11:
       mov       ecx,389E
       mov       rdx,7FFD3445A9D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3448C018]
       int       3
M00_L12:
       mov       rcx,18745804F48
       xor       edx,edx
       call      qword ptr [7FFD344859E0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,r14
       call      qword ptr [7FFD34485938]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L14:
       dec       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L15:
       mov       rcx,18745804F48
       xor       edx,edx
       call      qword ptr [7FFD344859E0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFD34485938]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L17:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,18700208830
       mov       r8d,1
       call      qword ptr [7FFD344851E8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L18:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,18700208830
       mov       r8d,1
       call      qword ptr [7FFD344851E8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L19:
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 707
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD344859B0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,18745801FF8
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFD34604A48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,18700201C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD34486CB8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFD341FE9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD3448D908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD345F72E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFD3445C4E8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18745804F88
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFD345F4858]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFD345F6DF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFD345F49D8]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFD341FE9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFD34115BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,18745801FF8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD34604A50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,228
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+200],xmm4
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+1F0],rax
       mov       [rbp],rsp
       mov       rax,0CB60FB96D6BC
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+18],rcx
       cmp       edi,55
       jg        near ptr M02_L08
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r8d,100
M02_L01:
       mov       [rbp+10],rax
       mov       [rbp+54],r8d
       mov       [rbp+40],rsi
       mov       [rbp+48],edi
       mov       rcx,[rbp+10]
       mov       [rbp+30],rcx
       mov       ecx,[rbp+54]
       mov       [rbp+38],ecx
       lea       rcx,[rbp+40]
       lea       rdx,[rbp+30]
       call      qword ptr [7FFD3448D968]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+54]
       ja        short M02_L04
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+54],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L03
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L02
       jmp       short M02_L05
M02_L02:
       mov       ecx,347F
       mov       rdx,7FFD3445A9D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3448C078]
       int       3
M02_L03:
       mov       ecx,347F
       mov       rdx,7FFD3445A9D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3448C0C0]
       int       3
M02_L04:
       call      qword ptr [7FFD341FE9D0]
       int       3
M02_L05:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1C0],r10
       mov       [rbp+1C8],r10
       mov       byte ptr [rbp+1D0],0
       mov       byte ptr [rbp+1D1],0
       mov       byte ptr [rbp+1D2],0
       mov       byte ptr [rbp+1D3],0
       mov       byte ptr [rbp+1D4],0
       mov       byte ptr [rbp+1D5],0
       mov       [rbp+1D8],ecx
       mov       [rbp+1DC],r8b
       mov       [rbp+1DD],r9b
       mov       byte ptr [rbp+1DE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+1E0],xmm0
       vmovdqu   xmmword ptr [rbp+1E8],xmm0
       mov       [rbp+20],rdx
       mov       [rbp+28],eax
       lea       rdx,[rbp+20]
       lea       rcx,[rbp+100]
       lea       r9,[rbp+1C0]
       mov       r8d,1
       call      qword ptr [7FFD345FD548]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+60],ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       lea       rcx,[rbp+60]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD345FE5F8]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+60]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+58]
       lea       rdx,[rbp+100]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34525938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rdi,[rbp+58]
       xor       edx,edx
       mov       [rbp+58],rdx
       cmp       qword ptr [rbp+18],0
       je        short M02_L06
       mov       edx,[rbp+54]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34115278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,18745801FF8
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FFD34604A50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M02_L06:
       mov       rax,rdi
       mov       rcx,0CB60FB96D6BC
       cmp       [rbp+8],rcx
       je        short M02_L07
       call      CORINFO_HELP_FAIL_FAST
M02_L07:
       nop
       lea       rsp,[rbp+1F8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L08:
       cmp       edi,15555555
       jbe       short M02_L09
       mov       [rbp+40],rsi
       mov       [rbp+48],edi
       lea       rcx,[rbp+40]
       call      qword ptr [7FFD3448D950]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L10
M02_L09:
       lea       edx,[rdi+rdi*2]
       mov       rcx,18745801FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFD34604A48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+18],rax
M02_L10:
       test      rax,rax
       jne       short M02_L11
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M02_L12
M02_L11:
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       mov       ecx,eax
       mov       rax,r8
       mov       r8d,ecx
M02_L12:
       jmp       near ptr M02_L01
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+18],0
       je        short M02_L13
       mov       edx,[rbp+54]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34115278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,18745801FF8
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FFD34604A50]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M02_L13:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 839
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M03_L03
       cmp       r8,4
       jae       short M03_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M03_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M03_L00:
       test      r8b,1
       je        short M03_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L03:
       cmp       rcx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L04:
       vzeroupper
       ret
M03_L05:
       mov       eax,1
       vzeroupper
       ret
M03_L06:
       cmp       r8,20
       jb        short M03_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M03_L08
M03_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M03_L13
       add       rax,20
       cmp       r8,rax
       ja        short M03_L07
M03_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       nop       dword ptr [rax]
       jmp       short M03_L05
       nop       dword ptr [rax]
M03_L09:
       cmp       r8,10
       jb        short M03_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M03_L11
M03_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M03_L13
       add       rax,10
       cmp       r8,rax
       ja        short M03_L10
M03_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M03_L13
       jmp       near ptr M03_L05
M03_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L04
M03_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD3E3DB908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFD34485368]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFD34484390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFD34487618]
       mov       [rbp-40],rax
       jmp       short M05_L01
M05_L00:
       call      qword ptr [7FFD34487510]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M05_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFD344853C8]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFD344875A0]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M05_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M05_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M06_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M06_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M06_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFD34484390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M06_L05
       call      qword ptr [7FFD34487510]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD34064360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M06_L03
       jmp       near ptr M06_L09
M06_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L09
M06_L03:
       call      qword ptr [7FFD34487720]
       test      eax,eax
       je        near ptr M06_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFD34524450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFD34524450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFD34524480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD344875E8]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M06_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34524318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34524318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34524318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD34485938]
       jmp       short M06_L09
M06_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34524390]
       jmp       short M06_L09
M06_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFD34064360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L07
M06_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M06_L08
M06_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M06_L08:
       cmp       dword ptr [rbp-34],0
       je        short M06_L09
       call      qword ptr [7FFD3448C978]
M06_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD344858F0]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M07_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD344851A0]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34524360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       cmp       qword ptr [rbp-8],0
       je        short M07_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD344865C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M07_L01
M07_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD34485950]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M07_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M07_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD34324720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M07_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD344853B0]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD3448CF60]
M07_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.FerrisValueMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rbx,rcx
       mov       rcx,24E930041A0
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+58]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFD33FD66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+68],0
       je        near ptr M00_L13
       cmp       dword ptr [rsp+68],1
       je        near ptr M00_L14
       mov       edi,[rsp+68]
       test      edi,edi
       jl        near ptr M00_L15
       mov       rbp,[rsp+58]
       test      rbp,rbp
       je        near ptr M00_L16
       cmp       [rbp+8],edi
       je        short M00_L01
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       cmp       edi,r8d
       cmovg     edi,r8d
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L03
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+58],r14
M00_L01:
       mov       ecx,[rsp+68]
       mov       [rsp+6C],ecx
       mov       rcx,[rsp+58]
M00_L02:
       mov       rdx,rsi
       call      qword ptr [7FFD3446FDC8]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       test      rax,rax
       jne       short M00_L04
       xor       edx,edx
       xor       r8d,r8d
       jmp       short M00_L05
M00_L03:
       call      qword ptr [7FFD34135BD8]
       jmp       short M00_L00
M00_L04:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
M00_L05:
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       mov       rdx,24E80208830
       lea       r8,[rsp+30]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFD3446FEA0]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M00_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L17
       mov       rax,[rcx]
       add       rax,10
M00_L06:
       mov       r8,[rax+8]
       test      r8,r8
       jne       short M00_L07
       mov       r8,24E93000438
       mov       r8,[r8]
       test      r8,r8
       jne       short M00_L07
       mov       r8,24E93000418
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M00_L18
M00_L07:
       mov       rcx,[rsp+40]
       mov       rdx,24E80208830
       call      qword ptr [7FFD3449D2D8]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       rsi,rax
       test      rsi,rsi
       je        short M00_L08
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.ValueTestObject
       cmp       [rsi],rcx
       je        short M00_L08
       mov       rdx,rax
       call      qword ptr [7FFD340843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M00_L08:
       mov       r8,24E930041A0
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rsi,rsi
       je        short M00_L11
       mov       rdx,[rsi+8]
M00_L09:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L10
       test      rdx,rdx
       je        short M00_L12
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L12
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD34135068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L12
M00_L10:
       inc       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L11:
       xor       edx,edx
       jmp       short M00_L09
M00_L12:
       dec       dword ptr [rbx+8]
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L13:
       mov       rcx,24E93001F30
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L14:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+60]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
       jmp       near ptr M00_L02
M00_L15:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD3421ED48]
       int       3
M00_L16:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+58],rax
       jmp       near ptr M00_L01
M00_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M00_L06
M00_L18:
       call      qword ptr [7FFD341C4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r8,rax
       jmp       near ptr M00_L07
; Total bytes of code 698
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       r14,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       rsi,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rdi,rdi
       je        near ptr M01_L03
       test      bl,1
       je        short M01_L00
       mov       rdx,rdi
       mov       rcx,24E93000590
       mov       rcx,[rcx]
       call      qword ptr [7FFD34494168]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rdi,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rdi+8]
       mov       eax,ecx
       cmp       word ptr [rdi+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rdi
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L23
       test      r15d,r15d
       je        near ptr M01_L11
       cmp       ecx,r15d
       je        near ptr M01_L10
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r15d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        near ptr M01_L12
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L12
       mov       r14,rax
M01_L05:
       mov       [rsp+38],rdi
       cmp       [r14],r14b
       lea       rdx,[r14+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L07
       mov       rax,[rsp+38]
M01_L06:
       mov       r14,r8
       cmp       [r14],r14b
       cmp       r12d,1
       je        near ptr M01_L13
       cmp       r12d,2
       je        near ptr M01_L15
       jmp       near ptr M01_L17
M01_L07:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,r14
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       lea       rcx,[rsp+50]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD34274FA8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       mov       ecx,[rsp+4C]
M01_L09:
       inc       ecx
       cmp       r14d,ecx
       jg        near ptr M01_L20
       jmp       near ptr M01_L22
M01_L10:
       mov       rdi,r12
       jmp       near ptr M01_L02
M01_L11:
       mov       rdi,24E80200008
       jmp       near ptr M01_L02
M01_L12:
       mov       rcx,r14
       call      qword ptr [7FFD33FD6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L13:
       lea       rcx,[r14+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD34275050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L14
       mov       rcx,r14
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFD34276838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L14:
       mov       r12,rax
       jmp       short M01_L19
M01_L15:
       lea       rcx,[r14+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFD34275050]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L16
       mov       rcx,r14
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFD34276838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L16:
       jmp       short M01_L19
M01_L17:
       cmp       byte ptr [r14+18],0
       je        short M01_L18
       mov       r12,[r14+8]
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFD34276838]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L19:
       xor       ebx,2
       mov       r14d,[r12+8]
       mov       ecx,r14d
       xor       edx,edx
       mov       [rsp+50],rdx
       mov       [rsp+58],rdx
       mov       [rsp+60],edx
       mov       [rsp+64],ecx
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M01_L22
M01_L20:
       mov       edx,ecx
       mov       rax,[r12+rdx*8+10]
       mov       [rsp+40],rax
       mov       edx,[rax+58]
       mov       r8d,ebx
       and       r8d,edx
       cmp       r8d,edx
       jne       near ptr M01_L09
       test      r15d,r15d
       jne       short M01_L24
       test      rsi,rsi
       jne       short M01_L21
       mov       [rsp+4C],ecx
       jmp       near ptr M01_L08
M01_L21:
       mov       [rsp+4C],ecx
       jmp       near ptr M01_L25
M01_L22:
       mov       rdx,[rsp+50]
       mov       rcx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rbp+10],eax
       mov       eax,[rsp+64]
       mov       [rbp+14],eax
       mov       rax,rbp
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFD34087258]
       int       3
M01_L24:
       mov       [rsp+4C],ecx
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8d,r13d
       call      qword ptr [7FFD33FD6538]
       test      eax,eax
       mov       ecx,[rsp+4C]
       je        near ptr M01_L09
       mov       rax,[rsp+40]
       test      rsi,rsi
       mov       [rsp+4C],ecx
       je        near ptr M01_L08
M01_L25:
       mov       rcx,rax
       call      qword ptr [7FFD3432D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[rsi+8]
       mov       ecx,[rsp+4C]
       jne       near ptr M01_L09
       mov       rax,[rsp+40]
       mov       [rsp+4C],ecx
       jmp       near ptr M01_L08
; Total bytes of code 879
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2A8
       vzeroupper
       vmovaps   [rsp+290],xmm6
       lea       rbp,[rsp+2E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-220],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M02_L01:
       vmovdqa   xmmword ptr [rbp+rax-60],xmm4
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rbp-60],rax
       mov       [rbp-2B0],rsp
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L131
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       mov       [rbp-208],rdi
       mov       [rbp-210],rsi
       xor       ecx,ecx
       mov       [rbp-54],ecx
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L24
M02_L03:
       mov       ecx,[rbp-54]
       mov       rcx,[rsi+rcx*8+10]
       mov       [rbp-218],rcx
       mov       rcx,[rbp-218]
       mov       r14,[rcx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L134
       mov       rcx,[rbp-218]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L132
       test      rcx,rcx
       je        near ptr M02_L133
M02_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFD34263270]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r13,rax
M02_L05:
       cmp       r14,r15
       jne       near ptr M02_L130
       mov       r12,[rbp-218]
       mov       rcx,[rbp-218]
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L129
M02_L06:
       mov       rcx,[r12+38]
       mov       r12,[rcx+18]
M02_L07:
       test      r13,r13
       je        near ptr M02_L127
       mov       rcx,24E80200020
       cmp       r12,rcx
       je        near ptr M02_L78
       mov       rcx,24E80208898
       cmp       r12,rcx
       je        near ptr M02_L78
       test      r12,r12
       je        short M02_L10
       mov       rcx,24E802088E0
       cmp       r12,rcx
       je        near ptr M02_L140
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M02_L135
       mov       rcx,r12
       test      rcx,rcx
       je        near ptr M02_L136
M02_L08:
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M02_L136
       mov       rdx,24E802088E0
       call      System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L09:
       test      eax,eax
       jne       near ptr M02_L140
M02_L10:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M02_L43
       mov       rcx,r12
       call      qword ptr [7FFD33FD7330]; System.RuntimeType.GetBaseType()
M02_L11:
       mov       rcx,24E802021B8
       cmp       rax,rcx
       je        near ptr M02_L44
M02_L12:
       mov       rcx,24E80208960
       cmp       r12,rcx
       je        near ptr M02_L13
       mov       rcx,24E80208660
       cmp       r12,rcx
       je        near ptr M02_L13
       mov       rcx,24E80204FC0
       cmp       r12,rcx
       je        near ptr M02_L13
       mov       rcx,24E80208988
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E80205F58
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E802089B0
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E802089D8
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E80208A00
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E80208A28
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E80204B88
       cmp       r12,rcx
       je        short M02_L13
       mov       rcx,24E80208A50
       cmp       r12,rcx
       jne       near ptr M02_L74
M02_L13:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       rcx,24E93001EE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFD34259EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       test      rax,rax
       je        near ptr M02_L46
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M02_L14:
       mov       [rbp-68],r8
       mov       [rbp-60],eax
       xor       edx,edx
       mov       [rbp-70],edx
       mov       byte ptr [rbp-6C],0
       mov       edx,[rbp-70]
       cmp       edx,[rbp-60]
       ja        near ptr M02_L51
       mov       rcx,[rbp-68]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L47
       mov       rdx,24E80208864
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-70]
       inc       edx
       mov       [rbp-70],edx
M02_L15:
       mov       rdx,[rbp-218]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L48
       mov       r12,[rbp-218]
       mov       rdx,[rbp-218]
       mov       r15,[rdx+8]
       test      r15,r15
       je        near ptr M02_L25
M02_L16:
       cmp       byte ptr [rbp-6C],0
       jne       near ptr M02_L49
M02_L17:
       test      r15,r15
       je        near ptr M02_L49
       mov       r8d,[rbp-70]
       cmp       r8d,[rbp-60]
       ja        near ptr M02_L51
       mov       rcx,[rbp-68]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-60]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L49
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-70]
       add       ecx,[r15+8]
       mov       [rbp-70],ecx
M02_L18:
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       r8,[rbp-68]
       mov       edx,ecx
       lea       r8,[r8+rdx*2]
       mov       edx,[rbp-60]
       sub       edx,ecx
       cmp       edx,2
       jb        near ptr M02_L50
       mov       rcx,24E8020894C
       mov       edx,[rcx]
       mov       [r8],edx
       mov       ecx,[rbp-70]
       add       ecx,2
       mov       [rbp-70],ecx
M02_L19:
       lea       rcx,[rbp-80]
       mov       r8,r13
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD34306EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rax,[rbp-68]
       mov       [rbp-1F0],rax
       mov       [rbp-1E8],ecx
       lea       rcx,[rbp-1F0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r12,[rbp-78]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-80],ymm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       test      r12,r12
       je        near ptr M02_L22
       mov       rcx,24E93001EE8
       mov       r15,[rcx]
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFD33FC5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L52
M02_L20:
       xor       eax,eax
       mov       dword ptr [rbp-158],1
       cmp       [rcx+8],r14d
       jbe       short M02_L21
       mov       dword ptr [rbp-154],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r12+8],edx
       jne       near ptr M02_L53
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rbp-280],r10
       mov       r9,[r10]
       mov       [rbp-288],r9
       mov       rcx,r10
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-280]
       mov       [rdx+8],ecx
       mov       rax,[rbp-288]
       test      rax,rax
       mov       [rbp-288],rax
       mov       eax,[rbp-154]
       jne       near ptr M02_L54
M02_L21:
       mov       rcx,24E930005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L68
M02_L22:
       mov       rdx,r13
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L73
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L23:
       mov       edx,[rbp-54]
       inc       edx
       mov       [rbp-54],edx
       mov       edx,[rsi+8]
       cmp       edx,[rbp-54]
       jg        near ptr M02_L03
M02_L24:
       mov       rdx,rdi
       mov       rcx,24E80200C60
       call      qword ptr [7FFD34086DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,24E80208AE0
       mov       r8,24E80208AF8
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       vmovaps   xmm6,[rsp+290]
       add       rsp,2A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L25:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-140],xmm0
       mov       rdx,[r12+48]
       lea       rcx,[rbp-140]
       call      qword ptr [7FFD34276B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-140]
       vmovups   [rbp-150],xmm0
       lea       rcx,[rbp-150]
       call      qword ptr [7FFD34276BE0]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L16
M02_L26:
       jmp       near ptr M02_L34
M02_L27:
       mov       rcx,[rbp-228]
       mov       r11,7FFD33F407B0
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,24E80200020
       cmp       rax,rcx
       je        short M02_L28
       mov       rcx,24E80208898
       cmp       rax,rcx
       jne       near ptr M02_L30
M02_L28:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,24E80208858
       mov       r8,24E80208858
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,[rbp-220]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-220]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-220]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L29
       lea       r8d,[rdx+1]
       mov       r10,[rbp-220]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L34
M02_L29:
       mov       rcx,[rbp-220]
       mov       rdx,rax
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L34
M02_L30:
       mov       rcx,rax
       call      qword ptr [7FFD33FD7330]; System.RuntimeType.GetBaseType()
       mov       rcx,24E802021B8
       cmp       rax,rcx
       jne       short M02_L32
       mov       rcx,r14
       call      System.Object.GetType()
       mov       rcx,rax
       mov       edx,1C
       call      qword ptr [7FFD33FCA6C8]; System.RuntimeType.GetProperties(System.Reflection.BindingFlags)
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD3446FDC8]
       mov       rcx,[rbp-220]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-220]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-220]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L31
       lea       r8d,[rdx+1]
       mov       r10,[rbp-220]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L34
M02_L31:
       mov       rcx,[rbp-220]
       mov       rdx,rax
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L34
M02_L32:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,[rbp-220]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp-220]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp-220]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M02_L33
       lea       r8d,[rdx+1]
       mov       r10,[rbp-220]
       mov       [r10+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L34
M02_L33:
       mov       rcx,[rbp-220]
       mov       rdx,rax
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L34:
       mov       rcx,[rbp-228]
       mov       r11,7FFD33F407A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L27
       mov       rcx,rsp
       call      M02_L189
       nop
M02_L35:
       mov       rdx,[rbp-220]
       mov       rcx,24E80200C60
       call      qword ptr [7FFD34086DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       r13,rax
       lea       rcx,[rbp-80]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341A56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rdx,[rbp-68]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L36
       mov       rcx,24E80208864
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-70]
       inc       ecx
       mov       [rbp-70],ecx
       jmp       short M02_L37
M02_L36:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A58F0]
M02_L37:
       mov       rcx,[rbp-218]
       mov       rax,[rbp-218]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rdx,[rbp-68]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L38
       mov       rcx,24E80208914
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rbp-70]
       add       ecx,3
       mov       [rbp-70],ecx
       jmp       short M02_L39
M02_L38:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208908
       call      qword ptr [7FFD341A58F0]
M02_L39:
       lea       rcx,[rbp-80]
       mov       rdx,r13
       call      qword ptr [7FFD341A5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rdx,[rbp-68]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L40
       mov       rcx,24E80208934
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rbp-70]
       inc       ecx
       mov       [rbp-70],ecx
       jmp       short M02_L41
M02_L40:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208928
       call      qword ptr [7FFD341A58F0]
M02_L41:
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,[rbp-208]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L42
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-210]
       jmp       near ptr M02_L23
M02_L42:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rbx,[rbp+18]
       mov       rsi,[rbp-210]
       jmp       near ptr M02_L23
M02_L43:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L11
M02_L44:
       mov       rcx,r12
       mov       edx,1C
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       cmp       dword ptr [rax+8],0
       je        near ptr M02_L12
       mov       rcx,r12
       mov       edx,1C
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,r13
       call      qword ptr [7FFD3446FDC8]
       mov       r13,rax
       mov       rcx,[rbp-218]
       mov       rax,[rbp-218]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,24E80208858
       mov       r8,24E80208940
       call      qword ptr [7FFD34086B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L45
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L45:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L46:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M02_L14
M02_L47:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A58F0]
       jmp       near ptr M02_L15
M02_L48:
       mov       rcx,[rbp-218]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rbp-6C],0
       je        near ptr M02_L17
M02_L49:
       lea       rcx,[rbp-80]
       mov       rdx,r15
       call      qword ptr [7FFD341A5848]
       jmp       near ptr M02_L18
M02_L50:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208940
       call      qword ptr [7FFD341A58F0]
       jmp       near ptr M02_L19
M02_L51:
       call      qword ptr [7FFD3421E9D0]
       int       3
M02_L52:
       mov       rcx,r15
       call      qword ptr [7FFD3424D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L20
M02_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFD346AEAC0]
       mov       r14,rax
       mov       ecx,1D3
       mov       rdx,7FFD33F34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFD3408F750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M02_L54:
       mov       rcx,[r15+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L188
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rbp-154],eax
       jne       short M02_L55
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFD3424D7E8]
       mov       r10,rax
M02_L55:
       mov       r10,[r10+8]
       mov       [rbp-290],r10
       mov       rcx,7FFD33FC5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD33FC5C38],0
       je        short M02_L56
       call      qword ptr [7FFD3408DC98]
       mov       edx,eax
       mov       [rbp-170],edx
       jmp       short M02_L59
M02_L56:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-174],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-174]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L57
       call      qword ptr [7FFD346CCC18]
       mov       edx,eax
       jmp       short M02_L58
M02_L57:
       mov       edx,ecx
       sar       edx,10
M02_L58:
       mov       [rbp-170],edx
M02_L59:
       mov       rcx,7FFD33FC5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-170]
       xor       edx,edx
       div       dword ptr [7FFD33FC5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L66
M02_L60:
       cmp       eax,[r8+8]
       jae       near ptr M02_L188
       mov       [rbp-168],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-298],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-178],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-298]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-17C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L62
       test      r10d,r10d
       jne       short M02_L63
       xor       edx,edx
       mov       [rax+14],edx
M02_L61:
       movsxd    rdx,r10d
       mov       r8,[rbp-288]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-17C]
       inc       ecx
       mov       rax,[rbp-298]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-178],1
M02_L62:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-178]
       test      ecx,ecx
       je        short M02_L64
       mov       r8d,1
       jmp       short M02_L67
M02_L63:
       jmp       short M02_L61
M02_L64:
       mov       eax,[rbp-168]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-290]
       cmp       [rcx+8],r8d
       jne       short M02_L65
       xor       r8d,r8d
M02_L65:
       mov       edx,[rbp-16C]
       inc       edx
       mov       eax,r8d
M02_L66:
       mov       r8,[rbp-290]
       mov       [rbp-16C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L60
       xor       r8d,r8d
M02_L67:
       mov       eax,r8d
       mov       [rbp-158],eax
       mov       eax,[rbp-154]
       jmp       near ptr M02_L21
M02_L68:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rbp-158]
       cmp       dword ptr [r12+8],0
       mov       [rbp-154],edx
       mov       [rbp-270],r8
       mov       [rbp-158],eax
       je        near ptr M02_L22
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-15C],eax
       mov       edx,[r12+8]
       mov       [rbp-160],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-270]
       mov       r8d,[rbp-15C]
       mov       r9d,[rbp-160]
       mov       edx,3
       call      qword ptr [7FFD34137678]
       mov       eax,[rbp-154]
       test      [rbp-158],eax
       mov       [rbp-154],eax
       jne       near ptr M02_L22
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rbp-270]
       mov       [rbp-278],rdx
       mov       [rbp-164],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rbp-154]
       test      r15d,r15d
       jne       short M02_L69
       mov       r14,[rbp-278]
       mov       edx,[rbp-164]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L70
M02_L69:
       mov       rdx,[rbp-278]
       mov       ecx,[rbp-164]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M02_L70:
       mov       r8d,r12d
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L71
       mov       eax,1
       jmp       short M02_L72
M02_L71:
       xor       eax,eax
M02_L72:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFD3424E2B0]
       jmp       near ptr M02_L22
M02_L73:
       mov       rcx,rdi
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L74:
       mov       rdx,24E80208A78
       cmp       r12,rdx
       jne       near ptr M02_L96
       mov       rdx,offset MT_System.Single
       cmp       [r13],rdx
       je        short M02_L75
       mov       rdx,r13
       mov       rcx,offset MT_System.Single
       call      qword ptr [7FFD34084408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M02_L75:
       vmovss    xmm6,dword ptr [r13+8]
       mov       rdx,[rbp-218]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L142
       mov       r12,[rbp-218]
       mov       rdx,[rbp-218]
       mov       r15,[rdx+8]
       test      r15,r15
       je        near ptr M02_L88
M02_L76:
       mov       rcx,24E93000428
       mov       rcx,[rcx]
       call      qword ptr [7FFD341AF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovaps   xmm0,xmm6
       mov       rdx,24E80208AA0
       call      qword ptr [7FFD341CFA98]; System.Number.FormatSingle(Single, System.String, System.Globalization.NumberFormatInfo)
       mov       r12,rax
       test      r15,r15
       je        near ptr M02_L143
       cmp       dword ptr [r15+8],0
       je        near ptr M02_L143
       test      r12,r12
       je        near ptr M02_L144
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L144
       mov       ecx,[r15+8]
       mov       eax,[r12+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L151
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r8,[r13+0C]
       mov       rcx,24E80208864
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r13+0E]
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r13+r8*2+0C]
       mov       rcx,24E8020894C
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r15+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r13+r8*2+0C]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r13
M02_L77:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L94
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L78:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       rcx,24E93001EE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFD34259EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-78],rax
       test      rax,rax
       je        near ptr M02_L156
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M02_L79:
       mov       [rbp-68],r8
       mov       [rbp-60],eax
       xor       edx,edx
       mov       [rbp-70],edx
       mov       byte ptr [rbp-6C],0
       mov       edx,[rbp-70]
       cmp       edx,[rbp-60]
       ja        near ptr M02_L51
       mov       rcx,[rbp-68]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,edx
       cmp       eax,1
       jb        near ptr M02_L157
       mov       rdx,24E80208864
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       edx,[rbp-70]
       inc       edx
       mov       [rbp-70],edx
       cmp       r14,r15
       jne       near ptr M02_L158
M02_L80:
       mov       r12,[rbp-218]
       mov       rdx,[rbp-218]
       mov       r15,[rdx+8]
       test      r15,r15
       je        near ptr M02_L87
M02_L81:
       cmp       byte ptr [rbp-6C],0
       jne       near ptr M02_L159
M02_L82:
       test      r15,r15
       je        near ptr M02_L159
       mov       r8d,[rbp-70]
       cmp       r8d,[rbp-60]
       ja        near ptr M02_L51
       mov       rcx,[rbp-68]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-60]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L159
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rbp-70]
       add       edx,[r15+8]
       mov       [rbp-70],edx
M02_L83:
       mov       edx,[rbp-70]
       cmp       edx,[rbp-60]
       ja        near ptr M02_L51
       mov       rcx,[rbp-68]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L160
       mov       rdx,24E802088CC
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rbp-70]
       add       edx,3
       mov       [rbp-70],edx
M02_L84:
       mov       [rbp-0E8],r13
       cmp       byte ptr [rbp-6C],0
       jne       near ptr M02_L141
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD34084348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L123
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD34084348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L86
M02_L85:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFD340843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rdx,[rbp-68]
       mov       r9d,ecx
       lea       rdx,[rdx+r9*2]
       mov       r9d,[rbp-60]
       sub       r9d,ecx
       xor       ecx,ecx
       mov       r8,offset MT_System.UInt16
       cmp       [rax],r8
       jne       near ptr M02_L100
       add       rax,8
       movzx     ecx,word ptr [rax]
       mov       r8d,ecx
       mov       r11d,ecx
       or        r11d,1
       lzcnt     r11d,r11d
       xor       r11d,1F
       mov       rax,7FFD3D9787A0
       add       r8,[rax+r11*8]
       sar       r8,20
       cmp       r8d,r9d
       jg        near ptr M02_L162
       mov       [rbp-0F8],r8d
       mov       [rbp-100],rdx
       movsxd    r9,r8d
       lea       r15,[rdx+r9*2]
       cmp       ecx,0A
       jb        near ptr M02_L103
       jmp       near ptr M02_L120
M02_L86:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFD340843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rbp-80]
       mov       r11,7FFD33F407C0
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L126
M02_L87:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D0],xmm0
       mov       rdx,[r12+48]
       lea       rcx,[rbp-0D0]
       call      qword ptr [7FFD34276B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D0]
       vmovups   [rbp-0E0],xmm0
       lea       rcx,[rbp-0E0]
       call      qword ptr [7FFD34276BE0]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L81
M02_L88:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-190],xmm0
       mov       rdx,[r12+48]
       lea       rcx,[rbp-190]
       call      qword ptr [7FFD34276B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-190]
       vmovups   [rbp-1A0],xmm0
       lea       rcx,[rbp-1A0]
       call      qword ptr [7FFD34276BE0]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L76
M02_L89:
       xor       ecx,ecx
       mov       [rbp-0F0],rcx
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rax,[rbp-68]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-60]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L166
       mov       rcx,24E80208864
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-70]
       inc       ecx
       mov       [rbp-70],ecx
M02_L90:
       mov       ecx,[rbp-70]
       cmp       ecx,[rbp-60]
       ja        near ptr M02_L51
       mov       rax,[rbp-68]
       mov       [rbp-1F0],rax
       mov       [rbp-1E8],ecx
       lea       rcx,[rbp-1F0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r14,[rbp-78]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-80],ymm0
       vmovdqu   xmmword ptr [rbp-68],xmm0
       test      r14,r14
       je        near ptr M02_L93
       mov       rcx,24E93001EE8
       mov       r12,[rcx]
       mov       ecx,[r14+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,7FFD33FC5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L167
M02_L91:
       xor       eax,eax
       mov       dword ptr [rbp-108],1
       cmp       [rcx+8],r15d
       jbe       short M02_L92
       mov       dword ptr [rbp-104],1
       mov       edx,10
       shlx      edx,edx,r15d
       cmp       [r14+8],edx
       jne       near ptr M02_L168
       mov       edx,r15d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rbp-250],r10
       mov       r9,[r10]
       mov       [rbp-258],r9
       mov       rcx,r10
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-250]
       mov       [rdx+8],ecx
       mov       rax,[rbp-258]
       test      rax,rax
       mov       [rbp-258],rax
       mov       eax,[rbp-104]
       jne       near ptr M02_L169
M02_L92:
       mov       rcx,24E930005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L183
M02_L93:
       mov       rdx,r13
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       short M02_L95
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L94:
       mov       rcx,rdi
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L95:
       mov       rcx,rdi
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L96:
       mov       rdx,24E80205718
       cmp       r12,rdx
       jne       near ptr M02_L108
       mov       rdx,offset MT_System.Double
       cmp       [r13],rdx
       je        short M02_L97
       mov       rdx,r13
       mov       rcx,offset MT_System.Double
       call      qword ptr [7FFD34084408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
M02_L97:
       vmovsd    xmm6,qword ptr [r13+8]
       mov       rdx,[rbp-218]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L145
       mov       r12,[rbp-218]
       mov       rdx,[rbp-218]
       mov       r13,[rdx+8]
       test      r13,r13
       je        near ptr M02_L105
M02_L98:
       mov       rcx,24E93000428
       mov       rcx,[rcx]
       call      qword ptr [7FFD341AF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       vmovaps   xmm0,xmm6
       mov       rdx,24E80208AA0
       call      qword ptr [7FFD341CFA38]; System.Number.FormatDouble(Double, System.String, System.Globalization.NumberFormatInfo)
       mov       r12,rax
       test      r13,r13
       je        near ptr M02_L146
       cmp       dword ptr [r13+8],0
       je        near ptr M02_L146
       test      r12,r12
       je        near ptr M02_L147
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L147
       mov       ecx,[r13+8]
       mov       eax,[r12+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L151
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r8,[r15+0C]
       mov       rcx,24E80208864
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r15+0E]
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r13+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r15+r8*2+0C]
       mov       rcx,24E8020894C
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r13+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r15
M02_L99:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L106
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L100:
       mov       r8,rax
       mov       [rbp-200],rdx
       mov       [rbp-1F8],r9d
       mov       [rbp-1F0],rcx
       xor       ecx,ecx
       mov       [rbp-1E8],ecx
       mov       rcx,[rbp-80]
       mov       [rsp+20],rcx
       mov       rcx,r8
       lea       rdx,[rbp-200]
       lea       r9,[rbp-1F0]
       lea       r8,[rbp-0F8]
       mov       r11,7FFD33F407C8
       call      qword ptr [r11]
M02_L101:
       test      eax,eax
       je        near ptr M02_L161
       mov       r8d,[rbp-70]
       add       r8d,[rbp-0F8]
       mov       [rbp-70],r8d
       jmp       near ptr M02_L89
M02_L102:
       xor       ecx,ecx
       mov       [rbp-100],rcx
       jmp       short M02_L101
M02_L103:
       add       ecx,30
       mov       [r15-2],cx
M02_L104:
       xor       ecx,ecx
       mov       [rbp-100],rcx
       mov       eax,1
       jmp       short M02_L102
M02_L105:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-1B0],xmm0
       mov       rdx,[r12+48]
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFD34276B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-1B0]
       vmovups   [rbp-1C0],xmm0
       lea       rcx,[rbp-1C0]
       call      qword ptr [7FFD34276BE0]; System.MdUtf8String.ToString()
       mov       r13,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L98
M02_L106:
       mov       rcx,rdi
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L107:
       cmp       [r14],r14b
       call      qword ptr [7FFD341C4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       near ptr M02_L113
       jmp       near ptr M02_L119
M02_L108:
       mov       rdx,24E80203C30
       cmp       r12,rdx
       jne       near ptr M02_L153
       mov       rdx,[rbp-218]
       mov       r14,[rdx]
       mov       r15,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r14,r15
       jne       near ptr M02_L117
       mov       r14,[rbp-218]
       mov       rdx,[rbp-218]
       mov       r12,[rdx+8]
       test      r12,r12
       je        near ptr M02_L115
M02_L109:
       mov       rax,offset MT_System.Boolean
       cmp       [r13],rax
       jne       near ptr M02_L118
       add       r13,8
       cmp       byte ptr [r13],0
       je        near ptr M02_L148
       mov       r14,24E80208B30
       jmp       near ptr M02_L107
M02_L110:
       cmp       dword ptr [r13+8],0
       je        near ptr M02_L150
       mov       ecx,[r12+8]
       mov       eax,[r13+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L151
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r8,[r15+0C]
       mov       rcx,24E80208864
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r15+0E]
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[r12+8]
       inc       eax
       cdqe
       lea       r14,[r15+rax*2+0C]
       mov       rax,24E8020894C
       mov       [rbp-2A0],rax
       call      qword ptr [7FFD34464E58]; System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.Char, System.Private.CoreLib]]()
       test      eax,eax
       jne       near ptr M02_L152
       mov       rax,[rbp-2A0]
       mov       edx,[rax]
       mov       [r14],edx
M02_L111:
       mov       edx,[r12+8]
       add       edx,3
       mov       rcx,r15
       mov       r8,r13
       call      qword ptr [7FFD34086A60]; System.String.CopyStringContent(System.String, Int32, System.String)
       mov       rdx,r15
M02_L112:
       mov       rcx,rdi
       call      qword ptr [7FFD341464B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M02_L23
M02_L113:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
M02_L114:
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFD34494168]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       r13,rax
       test      r12,r12
       je        near ptr M02_L149
       jmp       short M02_L116
M02_L115:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-1D0],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rbp-1D0]
       call      qword ptr [7FFD34276B68]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-1D0]
       vmovups   [rbp-1E0],xmm0
       lea       rcx,[rbp-1E0]
       call      qword ptr [7FFD34276BE0]; System.MdUtf8String.ToString()
       mov       r12,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L109
M02_L116:
       cmp       dword ptr [r12+8],0
       je        near ptr M02_L149
       test      r13,r13
       je        near ptr M02_L150
       jmp       near ptr M02_L110
M02_L117:
       mov       rcx,[rbp-218]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r12,rax
M02_L118:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M02_L107
M02_L119:
       mov       rcx,rax
       call      qword ptr [7FFD3419CFF8]; System.Globalization.CultureInfo.get_TextInfo()
       jmp       near ptr M02_L114
M02_L120:
       cmp       ecx,64
       jb        short M02_L122
       mov       rax,24E93000290
       mov       rax,[rax]
M02_L121:
       add       r15,0FFFFFFFFFFFFFFFC
       mov       edx,ecx
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       mov       r10d,ecx
       sub       r10d,r8d
       mov       ecx,edx
       mov       rdx,rax
       shl       r10d,2
       mov       r8d,r10d
       mov       edx,[rdx+r8+10]
       mov       [r15],edx
       cmp       ecx,64
       jae       short M02_L121
M02_L122:
       cmp       ecx,0A
       jb        near ptr M02_L103
       lea       rdx,[r15-4]
       mov       rax,24E93000290
       mov       rax,[rax]
       shl       ecx,2
       mov       ecx,[rax+rcx+10]
       mov       [rdx],ecx
       jmp       near ptr M02_L104
M02_L123:
       xor       r8d,r8d
       mov       [rbp-0F0],r8
       lea       r8,[rbp-0E8]
       cmp       qword ptr [rbp-0F0],0
       jne       short M02_L124
       mov       r8,[r8]
       mov       [rbp-0F0],r8
       lea       r8,[rbp-0F0]
       cmp       qword ptr [rbp-0F0],0
       je        near ptr M02_L163
M02_L124:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L164
M02_L125:
       mov       rdx,rcx
M02_L126:
       test      rdx,rdx
       je        near ptr M02_L89
       mov       r8d,[rbp-70]
       cmp       r8d,[rbp-60]
       ja        near ptr M02_L51
       mov       rcx,[rbp-68]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rbp-60]
       sub       eax,r8d
       mov       r14d,[rdx+8]
       cmp       r14d,eax
       ja        near ptr M02_L165
       add       rdx,0C
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFD34135B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rbp-70]
       mov       [rbp-70],r14d
       jmp       near ptr M02_L89
M02_L127:
       mov       rcx,[rbp-218]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,24E80208858
       mov       r8,24E80208870
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L128
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L23
M02_L128:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFD3413E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L23
M02_L129:
       mov       rcx,[r12+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rbp-238],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rbp-238]
       mov       [rbp-98],rdx
       mov       [rbp-90],rax
       lea       rdx,[rbp-0B8]
       mov       [rsp+20],rdx
       mov       edx,[r12+50]
       lea       rcx,[rbp-98]
       lea       r8,[rbp-0A0]
       lea       r9,[rbp-0A8]
       call      qword ptr [7FFD342D5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rbp-0B0]
       mov       [rbp-0C0],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-230],rax
       mov       r9,[r12+30]
       mov       rcx,rax
       mov       rdx,[rbp-0C0]
       mov       r8d,[rbp-0B8]
       call      qword ptr [7FFD34277B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r12+38]
       mov       rdx,[rbp-230]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L130:
       mov       rcx,[rbp-218]
       mov       rax,[r14+50]
       call      qword ptr [rax+10]
       mov       r12,rax
       jmp       near ptr M02_L07
M02_L131:
       mov       rcx,24E93001F00
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L132:
       xor       ecx,ecx
       test      rcx,rcx
       jne       near ptr M02_L04
M02_L133:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3408F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L134:
       mov       rcx,[rbp-218]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r14+58]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M02_L05
M02_L135:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M02_L08
M02_L136:
       mov       rdx,r12
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFD34084360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L10
       mov       rcx,r12
       mov       rdx,24E802088E0
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M02_L140
       mov       rcx,24E802088E0
       call      qword ptr [7FFD33FD4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M02_L137
       mov       rcx,r12
       mov       rdx,24E802088E0
       call      qword ptr [7FFD33FD6148]
       jmp       near ptr M02_L09
M02_L137:
       mov       rcx,24E802088E0
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        near ptr M02_L10
       mov       rcx,24E802088E0
       call      qword ptr [7FFD33FCA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       r14,rax
       xor       r15d,r15d
       jmp       short M02_L139
M02_L138:
       mov       ecx,r15d
       mov       rcx,[r14+rcx*8+10]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        near ptr M02_L10
       inc       r15d
M02_L139:
       cmp       [r14+8],r15d
       jg        short M02_L138
M02_L140:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       call      qword ptr [7FFD3413DF98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rbp-220],r12
       mov       rcx,[rbp-218]
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rbp-218]
       mov       r14,[rax]
       mov       rax,[r14+58]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFD34084348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L35
       mov       rcx,rax
       mov       r11,7FFD33F407A0
       call      qword ptr [r11]
       mov       [rbp-228],rax
       jmp       near ptr M02_L26
M02_L141:
       lea       rcx,[rbp-80]
       mov       r8,[rbp-0E8]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFD346CCDE0]
       jmp       near ptr M02_L89
M02_L142:
       mov       rcx,[rbp-218]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       jmp       near ptr M02_L76
M02_L143:
       mov       r8,r12
       mov       rcx,24E80208858
       mov       rdx,24E80208940
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L77
M02_L144:
       mov       rdx,r15
       mov       rcx,24E80208858
       mov       r8,24E80208940
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L77
M02_L145:
       mov       rcx,[rbp-218]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M02_L98
M02_L146:
       mov       r8,r12
       mov       rcx,24E80208858
       mov       rdx,24E80208940
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L99
M02_L147:
       mov       rdx,r13
       mov       rcx,24E80208858
       mov       r8,24E80208940
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L99
M02_L148:
       mov       r14,24E80208B10
       jmp       near ptr M02_L107
M02_L149:
       mov       r8,r13
       mov       rcx,24E80208858
       mov       rdx,24E80208940
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L112
M02_L150:
       mov       rdx,r12
       mov       rcx,24E80208858
       mov       r8,24E80208940
       call      qword ptr [7FFD34086B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L112
M02_L151:
       call      qword ptr [7FFD3421EF40]
       int       3
M02_L152:
       mov       rcx,r14
       mov       rdx,[rbp-2A0]
       mov       r8d,4
       call      qword ptr [7FFD34135BC0]
       jmp       near ptr M02_L111
M02_L153:
       mov       rdx,24E80208AB8
       cmp       r12,rdx
       jne       near ptr M02_L154
       mov       rdx,r13
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFD34084408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rax,[rax]
       mov       [rbp-88],rax
       call      qword ptr [7FFD341C4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       r8,rax
       lea       rcx,[rbp-88]
       mov       rdx,24E80206808
       call      qword ptr [7FFD3434F048]
       mov       r13,rax
       lea       rcx,[rbp-80]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341A56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,[rbp-218]
       mov       rax,[rbp-218]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-80]
       mov       rdx,24E802088C0
       call      qword ptr [7FFD341A5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-80]
       mov       rdx,r13
       call      qword ptr [7FFD341A5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       jmp       short M02_L155
M02_L154:
       lea       rcx,[rbp-80]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFD341A56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,[rbp-218]
       mov       rax,[rbp-218]
       mov       r14,[rax]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-80]
       mov       rdx,24E802088C0
       call      qword ptr [7FFD341A5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-80]
       mov       r8,r13
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFD34306EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
M02_L155:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A5788]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD341464B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M02_L23
M02_L156:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M02_L79
M02_L157:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A58F0]
       cmp       r14,r15
       je        near ptr M02_L80
M02_L158:
       mov       rcx,[rbp-218]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rbp-6C],0
       je        near ptr M02_L82
M02_L159:
       lea       rcx,[rbp-80]
       mov       rdx,r15
       call      qword ptr [7FFD341A5848]
       jmp       near ptr M02_L83
M02_L160:
       lea       rcx,[rbp-80]
       mov       rdx,24E802088C0
       call      qword ptr [7FFD341A58F0]
       jmp       near ptr M02_L84
M02_L161:
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A5938]
       jmp       near ptr M02_L85
M02_L162:
       xor       ecx,ecx
       mov       [rbp-0F8],ecx
       xor       eax,eax
       jmp       near ptr M02_L102
M02_L163:
       xor       edx,edx
       jmp       near ptr M02_L126
M02_L164:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L125
M02_L165:
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD341A58F0]
       jmp       near ptr M02_L89
M02_L166:
       lea       rcx,[rbp-80]
       mov       rdx,24E80208858
       call      qword ptr [7FFD341A58F0]
       jmp       near ptr M02_L90
M02_L167:
       mov       rcx,r12
       call      qword ptr [7FFD3424D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L91
M02_L168:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFD346AEAC0]
       mov       r15,rax
       mov       ecx,1D3
       mov       rdx,7FFD33F34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFD3408F750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M02_L169:
       mov       rcx,[r12+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M02_L188
       mov       edx,r15d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rbp-104],eax
       jne       short M02_L170
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FFD3424D7E8]
       mov       r10,rax
M02_L170:
       mov       r10,[r10+8]
       mov       [rbp-260],r10
       mov       rcx,7FFD33FC5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD33FC5C38],0
       je        short M02_L171
       call      qword ptr [7FFD3408DC98]
       mov       edx,eax
       mov       [rbp-120],edx
       jmp       short M02_L174
M02_L171:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-124],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-124]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L172
       call      qword ptr [7FFD346CCC18]
       mov       edx,eax
       jmp       short M02_L173
M02_L172:
       mov       edx,ecx
       sar       edx,10
M02_L173:
       mov       [rbp-120],edx
M02_L174:
       mov       rcx,7FFD33FC5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-120]
       xor       edx,edx
       div       dword ptr [7FFD33FC5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L181
M02_L175:
       cmp       eax,[r8+8]
       jae       near ptr M02_L188
       mov       [rbp-118],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-268],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-128],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-268]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-12C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L177
       test      r10d,r10d
       jne       short M02_L178
       xor       edx,edx
       mov       [rax+14],edx
M02_L176:
       movsxd    rdx,r10d
       mov       r8,[rbp-258]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-12C]
       inc       ecx
       mov       rax,[rbp-268]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-128],1
M02_L177:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-128]
       test      ecx,ecx
       je        short M02_L179
       mov       r8d,1
       jmp       short M02_L182
M02_L178:
       jmp       short M02_L176
M02_L179:
       mov       eax,[rbp-118]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-260]
       cmp       [rcx+8],r8d
       jne       short M02_L180
       xor       r8d,r8d
M02_L180:
       mov       edx,[rbp-11C]
       inc       edx
       mov       eax,r8d
M02_L181:
       mov       r8,[rbp-260]
       mov       [rbp-11C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L175
       xor       r8d,r8d
M02_L182:
       mov       eax,r8d
       mov       [rbp-108],eax
       mov       eax,[rbp-104]
       jmp       near ptr M02_L92
M02_L183:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rbp-108]
       cmp       dword ptr [r14+8],0
       mov       [rbp-104],edx
       mov       [rbp-240],r8
       mov       [rbp-108],eax
       je        near ptr M02_L93
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-10C],eax
       mov       edx,[r14+8]
       mov       [rbp-110],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-240]
       mov       r8d,[rbp-10C]
       mov       r9d,[rbp-110]
       mov       edx,3
       call      qword ptr [7FFD34137678]
       mov       eax,[rbp-104]
       test      [rbp-108],eax
       mov       [rbp-104],eax
       jne       near ptr M02_L93
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,[r14+8]
       mov       rdx,[rbp-240]
       mov       [rbp-248],rdx
       mov       [rbp-114],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-104]
       test      r12d,r12d
       jne       short M02_L184
       mov       r15,[rbp-248]
       mov       edx,[rbp-114]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L185
M02_L184:
       mov       rdx,[rbp-248]
       mov       ecx,[rbp-114]
       mov       r8d,ecx
       mov       ecx,r15d
       mov       r15,rdx
       mov       edx,r8d
M02_L185:
       mov       r8d,r14d
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L186
       mov       eax,1
       jmp       short M02_L187
M02_L186:
       xor       eax,eax
M02_L187:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FFD3424E2B0]
       jmp       near ptr M02_L93
M02_L188:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L189:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+2E0]
       mov       rdx,[rbp-228]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFD34084348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L190
       mov       rcx,rax
       mov       r11,7FFD33F407B8
       call      qword ptr [r11]
M02_L190:
       nop
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 9317
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,2B8
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+150],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M03_L01:
       vmovdqa   xmmword ptr [rsp+rax+2B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2C0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2D0],xmm4
       add       rax,30
       jne       short M03_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       r14,offset MT_System.RuntimeType
       cmp       [rbx],r14
       jne       near ptr M03_L102
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+218]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFD33FD66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+228],0
       je        near ptr M03_L94
       cmp       dword ptr [rsp+228],1
       je        near ptr M03_L95
       mov       r15d,[rsp+228]
       test      r15d,r15d
       jl        near ptr M03_L96
       mov       r13,[rsp+218]
       test      r13,r13
       je        near ptr M03_L97
       cmp       [r13+8],r15d
       je        short M03_L03
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       cmp       r15d,r8d
       cmovg     r15d,r8d
       mov       r8d,r15d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M03_L38
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M03_L02:
       mov       [rsp+218],r12
M03_L03:
       mov       ecx,[rsp+228]
       mov       [rsp+22C],ecx
       mov       r15,[rsp+218]
M03_L04:
       mov       rcx,24E93004E90
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M03_L32
M03_L05:
       mov       rcx,24E93004E98
       mov       r9,[rcx]
       test      r9,r9
       je        short M03_L07
M03_L06:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFD3449F480]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r15,rax
       mov       [rsp+148],r15
       cmp       [rbx],r14
       jne       near ptr M03_L103
       mov       rcx,rbx
       jmp       near ptr M03_L71
M03_L07:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,24E93004E88
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD3449B2E8
       mov       [r12+18],rcx
       mov       rcx,24E93004E98
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r12
       jmp       near ptr M03_L06
M03_L08:
       mov       r12d,1
       xor       ebx,ebx
       mov       [rsp+140],rbx
       xor       eax,eax
       mov       [rsp+138],rax
       xor       r10d,r10d
       mov       [rsp+130],r10
       xor       r9d,r9d
       mov       [rsp+128],r9
M03_L09:
       mov       r11,rdi
       mov       r8d,ebp
       test      r8d,r8d
       je        near ptr M03_L106
       movzx     ecx,word ptr [r11]
       cmp       ecx,7B
       je        near ptr M03_L31
       cmp       ecx,7D
       je        near ptr M03_L29
       cmp       ecx,22
       je        near ptr M03_L20
       cmp       ecx,3A
       jne       near ptr M03_L13
       mov       edx,9
M03_L10:
       mov       ecx,edx
       mov       [rsp+214],ecx
       cmp       ecx,6
       je        short M03_L11
       cmp       ecx,7
       jne       near ptr M03_L48
M03_L11:
       cmp       ecx,6
       jne       near ptr M03_L64
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1F8],xmm0
       cmp       r8d,1
       jb        near ptr M03_L166
       add       r11,2
       sub       r8d,1
       mov       [rsp+68],r11
       mov       [rsp+174],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD343056C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+20C],eax
       cmp       eax,[rsp+174]
       ja        near ptr M03_L166
       mov       rcx,[rsp+68]
       mov       [rsp+1F8],rcx
       mov       [rsp+200],eax
       lea       rcx,[rsp+1F8]
       call      qword ptr [7FFD3413C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+60],rax
       mov       edx,[rsp+20C]
       add       edx,2
       mov       [rsp+170],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0B8],rax
       mov       dword ptr [rax+10],6
       mov       edx,[rsp+170]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0B8]
M03_L12:
       mov       r8,rax
       jmp       short M03_L15
M03_L13:
       cmp       ecx,2C
       jne       short M03_L16
       mov       edx,8
       jmp       near ptr M03_L10
M03_L14:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       eax,[rsp+214]
       mov       [r8+10],eax
       mov       dword ptr [r8+14],1
       mov       byte ptr [r8+18],0
       mov       r10,r8
       mov       r8,r10
M03_L15:
       mov       rdx,r8
       mov       [rsp+120],rdx
       mov       r8d,[rdx+10]
       mov       [rsp+2B4],r8d
       mov       r11d,[rdx+14]
       mov       [rsp+2B0],r11d
       cmp       r8d,2
       je        near ptr M03_L93
       jmp       short M03_L18
M03_L16:
       cmp       ecx,5B
       je        near ptr M03_L98
       cmp       ecx,5D
       je        near ptr M03_L99
       cmp       ecx,20
       je        near ptr M03_L100
       cmp       r12d,9
       jne       near ptr M03_L101
M03_L17:
       mov       edx,7
       jmp       near ptr M03_L10
M03_L18:
       cmp       r8d,8
       je        short M03_L21
       cmp       r8d,5
       jne       short M03_L19
       mov       r8d,[rsp+2B4]
       jmp       short M03_L21
M03_L19:
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L20:
       cmp       r12d,9
       je        short M03_L17
       mov       edx,6
       jmp       near ptr M03_L10
M03_L21:
       cmp       r12d,7
       jne       near ptr M03_L30
       mov       rax,[rsp+138]
       test      rax,rax
       je        near ptr M03_L28
       cmp       dword ptr [rax+10],6
       jne       near ptr M03_L27
       mov       [rsp+138],rax
       mov       rcx,[rax+8]
       test      rcx,rcx
       je        near ptr M03_L30
       mov       r10,[rsp+130]
       test      r10,r10
       je        near ptr M03_L26
       mov       [rsp+130],r10
       cmp       dword ptr [r10+10],9
       jne       near ptr M03_L30
       mov       r9,[rsp+128]
       test      r9,r9
       je        short M03_L25
       cmp       dword ptr [r9+10],7
       jne       short M03_L24
       mov       [rsp+128],r9
       movzx     ebx,byte ptr [r9+18]
M03_L22:
       test      ebx,ebx
       je        short M03_L30
       mov       [rsp+0D8],rcx
       mov       rbx,rcx
       test      rbx,rbx
       je        short M03_L23
       jmp       near ptr M03_L87
M03_L23:
       jmp       near ptr M03_L88
M03_L24:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       jmp       near ptr M03_L86
M03_L25:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       jmp       near ptr M03_L86
M03_L26:
       mov       [rsp+130],r10
       jmp       short M03_L30
M03_L27:
       mov       [rsp+138],rax
       jmp       short M03_L30
M03_L28:
       mov       [rsp+138],rax
       jmp       short M03_L30
M03_L29:
       mov       edx,5
       jmp       near ptr M03_L10
M03_L30:
       cmp       r8d,4
       jne       short M03_L33
       jmp       near ptr M03_L92
M03_L31:
       mov       edx,4
       jmp       near ptr M03_L10
M03_L32:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,24E93004E88
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFD3449B2D0
       mov       [r13+18],rcx
       mov       rcx,24E93004E90
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L05
M03_L33:
       cmp       r8d,0A
       je        near ptr M03_L145
M03_L34:
       cmp       r8d,5
       je        near ptr M03_L91
       cmp       r8d,8
       je        short M03_L36
       cmp       r8d,3
       je        short M03_L36
       cmp       r8d,6
       je        short M03_L35
       cmp       r8d,9
       jne       near ptr M03_L50
       jmp       near ptr M03_L83
M03_L35:
       mov       rdx,[rsp+120]
       mov       rax,rdx
       mov       [rsp+138],rax
M03_L36:
       cmp       r8d,3
       je        short M03_L37
       mov       r12d,r8d
M03_L37:
       mov       r11d,[rsp+2B0]
       cmp       r11d,ebp
       ja        near ptr M03_L166
       mov       edx,r11d
       lea       rdi,[rdi+rdx*2]
       sub       ebp,r11d
       jmp       near ptr M03_L09
M03_L38:
       call      qword ptr [7FFD34135BD8]
       jmp       near ptr M03_L02
M03_L39:
       test      eax,eax
       jne       near ptr M03_L53
       mov       r10,[rsp+0A8]
       lea       rcx,[rsp+1B0]
       mov       rdx,r10
       mov       r8,[rsp+0B0]
       call      qword ptr [7FFD3449F450]; Ferris.Json.Libs.MapValue(System.Type, System.Object)
       mov       rax,[rsp+1B0]
       mov       [rsp+0A0],rax
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L141
       mov       rcx,rbx
       cmp       qword ptr [rcx+20],0
       je        near ptr M03_L138
       mov       rbx,[rcx+20]
M03_L40:
       test      rbx,rbx
       je        near ptr M03_L161
       cmp       qword ptr [rbx+48],0
       je        near ptr M03_L52
M03_L41:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       je        short M03_L42
       mov       rcx,rbx
       call      qword ptr [7FFD342758F0]
M03_L42:
       test      byte ptr [rbx+5C],10
       jne       short M03_L45
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M03_L139
       mov       rcx,[rbx+38]
       cmp       [rcx],r14
       jne       near ptr M03_L140
M03_L43:
       mov       rdx,r13
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
M03_L44:
       test      eax,eax
       je        near ptr M03_L162
M03_L45:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M03_L51
M03_L46:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M03_L163
       cmp       qword ptr [rbx+48],0
       je        short M03_L49
M03_L47:
       mov       rax,[rsp+0A0]
       mov       [rsp+20],rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbx+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD342779C0]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L48:
       cmp       ecx,3
       je        near ptr M03_L127
       jmp       near ptr M03_L14
M03_L49:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+70],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD342778A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L47
M03_L50:
       cmp       r8d,7
       jne       near ptr M03_L90
       jmp       near ptr M03_L66
M03_L51:
       mov       rcx,rbx
       call      qword ptr [7FFD34275920]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M03_L46
M03_L52:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+78],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD342778A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L41
M03_L53:
       mov       rcx,offset MT_System.String
       mov       rdx,[rsp+0B0]
       cmp       [rdx],rcx
       jne       near ptr M03_L132
       mov       rcx,rdx
M03_L54:
       test      rcx,rcx
       je        short M03_L55
       mov       rdx,24E80208C18
       xor       r8d,r8d
       call      qword ptr [7FFD340862F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       near ptr M03_L133
M03_L55:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L137
       cmp       qword ptr [rbx+20],0
       je        near ptr M03_L134
       mov       rbx,[rbx+20]
M03_L56:
       test      rbx,rbx
       je        near ptr M03_L158
       cmp       qword ptr [rbx+48],0
       je        near ptr M03_L70
M03_L57:
       mov       rcx,[rbx+48]
       test      dword ptr [rcx+3C],102
       je        short M03_L58
       mov       rcx,rbx
       call      qword ptr [7FFD342758F0]
M03_L58:
       test      byte ptr [rbx+5C],10
       jne       short M03_L61
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M03_L135
       mov       rcx,[rbx+38]
       cmp       [rcx],r14
       jne       near ptr M03_L136
M03_L59:
       mov       rdx,r13
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
M03_L60:
       test      eax,eax
       je        near ptr M03_L159
M03_L61:
       mov       rax,[rbx+30]
       test      rax,rax
       je        near ptr M03_L69
M03_L62:
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M03_L160
       cmp       qword ptr [rbx+48],0
       je        short M03_L65
M03_L63:
       mov       rax,[rsp+0B0]
       mov       [rsp+20],rax
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rcx,[rbx+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFD342779C0]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L64:
       cmp       ecx,7
       jne       near ptr M03_L126
       test      r8d,r8d
       je        near ptr M03_L167
       movzx     ecx,word ptr [r11]
       cmp       ecx,22
       jne       near ptr M03_L78
       jmp       near ptr M03_L72
M03_L65:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+80],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD342778A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+80]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L63
M03_L66:
       mov       rdx,[rsp+120]
       mov       [rsp+128],rdx
       jmp       near ptr M03_L36
M03_L67:
       mov       rax,[rsp+128]
       cmp       byte ptr [rax+18],0
       je        short M03_L68
       mov       [rsp+128],rax
       mov       rdx,[rax+8]
       mov       [rsp+0B0],rdx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbx],rcx
       jne       near ptr M03_L128
       mov       rcx,rbx
       cmp       qword ptr [rcx+38],0
       jne       near ptr M03_L75
       jmp       near ptr M03_L74
M03_L68:
       mov       [rsp+128],rax
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L69:
       mov       rcx,rbx
       call      qword ptr [7FFD34275920]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       jmp       near ptr M03_L62
M03_L70:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+88],rax
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFD342778A0]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       lea       rcx,[rbx+48]
       mov       rdx,[rsp+88]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L57
M03_L71:
       test      rcx,rcx
       je        near ptr M03_L104
       cmp       [rcx],r14
       jne       near ptr M03_L104
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FD6E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M03_L105
       jmp       near ptr M03_L08
M03_L72:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1E0],xmm0
       cmp       r8d,1
       jb        near ptr M03_L166
       add       r11,2
       sub       r8d,1
       mov       [rsp+58],r11
       mov       [rsp+16C],r8d
       mov       edx,22
       mov       rcx,r11
       call      qword ptr [7FFD343056C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jle       short M03_L73
       lea       ecx,[rax-1]
       mov       edx,[rsp+16C]
       cmp       ecx,edx
       jae       near ptr M03_L167
       lea       ecx,[rax-1]
       mov       r11,[rsp+58]
       cmp       word ptr [r11+rcx*2],5C
       je        near ptr M03_L107
M03_L73:
       cmp       eax,[rsp+16C]
       ja        near ptr M03_L166
       mov       r11,[rsp+58]
       mov       [rsp+1F4],eax
       mov       ecx,eax
       mov       [rsp+1E0],r11
       mov       [rsp+1E8],ecx
       lea       rcx,[rsp+1E0]
       call      qword ptr [7FFD3413C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+50],rax
       mov       edx,[rsp+1F4]
       add       edx,2
       mov       [rsp+168],edx
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C0],rax
       mov       dword ptr [rax+10],7
       mov       edx,[rsp+168]
       mov       [rax+14],edx
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       jmp       near ptr M03_L12
M03_L74:
       mov       rcx,[rbx+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+90],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+90]
       mov       [rsp+1A0],rdx
       mov       [rsp+1A8],rax
       lea       rdx,[rsp+180]
       mov       [rsp+20],rdx
       mov       edx,[rbx+50]
       lea       rcx,[rsp+1A0]
       lea       r8,[rsp+198]
       lea       r9,[rsp+190]
       call      qword ptr [7FFD342D5740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+188]
       mov       [rsp+178],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r9,[rbx+30]
       mov       rcx,rax
       mov       rdx,[rsp+178]
       mov       r8d,[rsp+180]
       call      qword ptr [7FFD34277B10]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[rbx+38]
       mov       rdx,[rsp+98]
       call      CORINFO_HELP_ASSIGN_REF
M03_L75:
       mov       rcx,[rbx+38]
       mov       r8,[rcx+18]
M03_L76:
       mov       r10,r8
       mov       [rsp+0A8],r10
       mov       rcx,24E80200020
       cmp       r10,rcx
       je        near ptr M03_L53
       cmp       [r10],r14
       jne       near ptr M03_L129
       mov       rcx,r10
       call      qword ptr [7FFD33FD7330]; System.RuntimeType.GetBaseType()
M03_L77:
       mov       rcx,24E802021B8
       cmp       rax,rcx
       je        near ptr M03_L53
       mov       rdx,[rsp+0A8]
       cmp       [rdx],r14
       jne       near ptr M03_L131
       mov       rcx,rdx
       call      System.RuntimeTypeHandle.GetCorElementType(System.RuntimeType)
       cmp       eax,14
       je        near ptr M03_L130
       cmp       eax,1D
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L39
M03_L78:
       mov       [rsp+40],r11
       mov       [rsp+160],r8d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       mov       edx,2C
       mov       rcx,r11
       mov       r8d,[rsp+160]
       call      qword ptr [7FFD343056C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+1D8],eax
       mov       edx,7D
       mov       rcx,[rsp+40]
       mov       r8d,[rsp+160]
       call      qword ptr [7FFD343056C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+1D4],eax
       mov       edx,5D
       mov       rcx,[rsp+40]
       mov       r8d,[rsp+160]
       call      qword ptr [7FFD343056C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       edx,[rsp+1D8]
       test      edx,edx
       jl        near ptr M03_L111
M03_L79:
       mov       r8d,[rsp+1D4]
       test      r8d,r8d
       jl        near ptr M03_L114
M03_L80:
       test      edx,edx
       jl        near ptr M03_L84
       test      r8d,r8d
       jl        near ptr M03_L116
       test      eax,eax
       jge       near ptr M03_L120
       cmp       edx,r8d
       jg        near ptr M03_L119
       mov       r9d,edx
M03_L81:
       mov       r11d,r9d
M03_L82:
       cmp       r11d,[rsp+160]
       ja        near ptr M03_L166
       mov       rcx,[rsp+40]
       mov       [rsp+1D0],r11d
       mov       eax,r11d
       mov       [rsp+1C0],rcx
       mov       [rsp+1C8],eax
       lea       rcx,[rsp+1C0]
       call      qword ptr [7FFD3413C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       [rsp+38],rax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       dword ptr [rax+10],7
       mov       r8d,[rsp+1D0]
       mov       [rax+14],r8d
       mov       byte ptr [rax+18],0
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C8]
       jmp       near ptr M03_L12
M03_L83:
       mov       rdx,[rsp+120]
       mov       [rsp+130],rdx
       jmp       near ptr M03_L36
M03_L84:
       cmp       r8d,eax
       jg        near ptr M03_L125
       mov       r10d,r8d
M03_L85:
       mov       r9d,r10d
       mov       r11d,r9d
       jmp       near ptr M03_L82
M03_L86:
       xor       ebx,ebx
       mov       [rsp+128],r9
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L22
M03_L87:
       mov       r15,offset MT_System.String
       cmp       [rbx],r15
       jne       near ptr M03_L157
       mov       r15,[rsp+148]
M03_L88:
       cmp       [r15],r15b
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFD3408EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L89
       mov       rbx,[rax]
       jmp       near ptr M03_L67
M03_L89:
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L90:
       cmp       r8d,4
       jne       near ptr M03_L36
       mov       rbx,[rsp+140]
       test      rbx,rbx
       mov       [rsp+140],rbx
       jne       near ptr M03_L36
       mov       rdx,[rsp+120]
       mov       rbx,rdx
       mov       [rsp+140],rbx
       jmp       near ptr M03_L36
M03_L91:
       mov       r11d,[rsp+2B0]
       cmp       r11d,ebp
       ja        near ptr M03_L166
       mov       r10d,r11d
       lea       rdi,[rdi+r10*2]
       sub       ebp,r11d
       jmp       short M03_L93
M03_L92:
       cmp       r12d,9
       je        near ptr M03_L142
       jmp       near ptr M03_L33
M03_L93:
       mov       rcx,rsi
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,2B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L94:
       mov       rcx,24E93001F30
       mov       r15,[rcx]
       jmp       near ptr M03_L04
M03_L95:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rsp+220]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L04
M03_L96:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFD3421ED48]
       int       3
M03_L97:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+218],rax
       jmp       near ptr M03_L03
M03_L98:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       mov       edx,0A
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L10
M03_L99:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       mov       edx,0B
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L10
M03_L100:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       mov       edx,3
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L10
M03_L101:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       xor       edx,edx
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L10
M03_L102:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M03_L04
M03_L103:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M03_L71
M03_L104:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD346ACE58]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFD33F34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFD3408F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L105:
       mov       [rsp+238],rdi
       mov       [rsp+240],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+230]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+240]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,2B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L106:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       mov       edx,2
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L10
M03_L107:
       mov       r10,[rsp+130]
       mov       r11d,eax
       mov       r8,[rsp+58]
       mov       [rsp+48],r8
       mov       edx,[rsp+16C]
       mov       [rsp+164],edx
       jmp       short M03_L109
M03_L108:
       lea       ecx,[rax+1]
       cmp       ecx,[rsp+164]
       mov       [rsp+130],r10
       ja        near ptr M03_L166
       mov       eax,ecx
       mov       r11,[rsp+48]
       lea       r11,[r11+rax*2]
       mov       eax,[rsp+164]
       sub       eax,ecx
       mov       edx,22
       mov       [rsp+48],r11
       mov       rcx,r11
       mov       [rsp+164],eax
       mov       r8d,eax
       call      qword ptr [7FFD343056C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       ecx,eax
       mov       r11d,[rsp+1DC]
       lea       r11d,[r11+rcx+1]
       mov       eax,ecx
       mov       edx,[rsp+16C]
       mov       r8,[rsp+58]
       mov       r10,[rsp+130]
M03_L109:
       test      eax,eax
       jle       short M03_L110
       lea       ecx,[r11-1]
       cmp       ecx,edx
       jae       near ptr M03_L167
       mov       [rsp+1DC],r11d
       lea       ecx,[r11-1]
       cmp       word ptr [r8+rcx*2],5C
       je        near ptr M03_L108
       mov       edx,[rsp+16C]
       mov       r8,[rsp+58]
       mov       r11d,[rsp+1DC]
M03_L110:
       mov       ecx,r11d
       mov       [rsp+130],r10
       mov       eax,ecx
       jmp       near ptr M03_L73
M03_L111:
       mov       r10,[rsp+130]
       mov       ecx,[rsp+1D4]
       test      ecx,ecx
       jge       short M03_L112
       mov       r8d,eax
       mov       [rsp+130],r10
       mov       r11d,r8d
       jmp       near ptr M03_L82
M03_L112:
       test      eax,eax
       jge       short M03_L113
       mov       ecx,[rsp+1D4]
       mov       r8d,ecx
       mov       [rsp+130],r10
       mov       r11d,r8d
       jmp       near ptr M03_L82
M03_L113:
       mov       [rsp+130],r10
       jmp       near ptr M03_L79
M03_L114:
       mov       r10,[rsp+130]
       test      eax,eax
       jge       short M03_L115
       mov       ecx,edx
       mov       [rsp+130],r10
       mov       r11d,ecx
       jmp       near ptr M03_L82
M03_L115:
       mov       [rsp+130],r10
       jmp       near ptr M03_L80
M03_L116:
       mov       r10,[rsp+130]
       cmp       edx,eax
       jle       short M03_L117
       mov       ecx,eax
       jmp       short M03_L118
M03_L117:
       mov       ecx,edx
M03_L118:
       mov       [rsp+130],r10
       mov       r11d,ecx
       jmp       near ptr M03_L82
M03_L119:
       mov       r10,[rsp+130]
       mov       [rsp+130],r10
       mov       r9d,r8d
       jmp       near ptr M03_L81
M03_L120:
       mov       r10,[rsp+130]
       cmp       r8d,eax
       jle       short M03_L121
       mov       ecx,eax
       jmp       short M03_L122
M03_L121:
       mov       ecx,r8d
M03_L122:
       cmp       edx,ecx
       jle       short M03_L123
       jmp       short M03_L124
M03_L123:
       mov       ecx,edx
M03_L124:
       mov       [rsp+130],r10
       mov       r11d,ecx
       jmp       near ptr M03_L82
M03_L125:
       mov       r10,[rsp+130]
       mov       ecx,eax
       mov       [rsp+130],r10
       mov       r10d,ecx
       jmp       near ptr M03_L85
M03_L126:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsp+214]
       mov       [rax+10],ecx
       xor       ecx,ecx
       mov       [rax+14],ecx
       mov       byte ptr [rax+18],0
       jmp       near ptr M03_L12
M03_L127:
       mov       [rsp+150],r11
       mov       [rsp+158],r8d
       lea       rcx,[rsp+150]
       call      qword ptr [7FFD3446FEE8]
       mov       [rsp+210],eax
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r10,rax
       mov       [rsp+0D0],r10
       mov       rcx,r10
       mov       edx,3
       mov       r8d,[rsp+210]
       call      qword ptr [7FFD3449F210]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       r10,[rsp+0D0]
       mov       rcx,r10
       mov       r8,rcx
       jmp       near ptr M03_L15
M03_L128:
       mov       rcx,rbx
       mov       r9,[rbx]
       mov       r9,[r9+50]
       call      qword ptr [r9+10]
       mov       rcx,rax
       mov       r8,rcx
       jmp       near ptr M03_L76
M03_L129:
       mov       rcx,r10
       mov       r8,[r10]
       mov       r8,[r8+98]
       call      qword ptr [r8+20]
       jmp       near ptr M03_L77
M03_L130:
       mov       eax,1
       jmp       near ptr M03_L39
M03_L131:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M03_L39
M03_L132:
       mov       rcx,rdx
       mov       r8,[rdx]
       mov       r8,[r8+40]
       call      qword ptr [r8+8]
       mov       rcx,rax
       jmp       near ptr M03_L54
M03_L133:
       mov       rcx,rbx
       mov       rdx,r13
       xor       r8d,r8d
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L134:
       xor       ebx,ebx
       jmp       near ptr M03_L56
M03_L135:
       xor       ecx,ecx
       cmp       [rcx],r14
       je        near ptr M03_L59
M03_L136:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       jmp       near ptr M03_L60
M03_L137:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r8,[rsp+0B0]
       xor       r9d,r9d
       mov       r10,[rbx]
       mov       r10,[r10+60]
       call      qword ptr [r10+18]
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L138:
       mov       rax,[rsp+0A0]
       xor       ebx,ebx
       jmp       near ptr M03_L40
M03_L139:
       mov       rax,[rsp+0A0]
       xor       ecx,ecx
       cmp       [rcx],r14
       je        near ptr M03_L43
M03_L140:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       jmp       near ptr M03_L44
M03_L141:
       mov       rax,[rsp+0A0]
       mov       rcx,rbx
       mov       rdx,r13
       mov       r8,rax
       xor       r9d,r9d
       mov       rax,[rbx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L30
M03_L142:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       mov       [rsp+138],rax
       mov       rcx,rax
       mov       [rsp+130],r10
       mov       rdx,r10
       call      qword ptr [7FFD3446FE58]
       test      eax,eax
       mov       r8d,[rsp+2B4]
       je        near ptr M03_L36
       mov       r10,[rsp+130]
       mov       rax,[rsp+138]
       mov       rdx,[rax+8]
       mov       [rsp+0E8],rdx
       mov       rcx,rdx
       mov       [rsp+0E0],rcx
       test      rcx,rcx
       je        near ptr M03_L144
       mov       rax,[rsp+138]
       mov       rdx,offset MT_System.String
       cmp       [rcx],rdx
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jne       near ptr M03_L164
M03_L143:
       lea       r8,[rsp+2A8]
       mov       rcx,r15
       mov       rdx,[rsp+0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34114630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       mov       r8d,[rsp+2B4]
       je        near ptr M03_L36
       mov       rcx,[rsp+2A8]
       mov       rdx,[rsp+2A8]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rdx,rax
       mov       [rsp+150],rdi
       mov       [rsp+158],ebp
       lea       r8,[rsp+150]
       lea       rcx,[rsp+290]
       call      qword ptr [7FFD3446FEA0]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD3449F210]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+290]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+128],r12
       mov       ebp,7
       mov       rdi,[rsp+298]
       mov       ecx,[rsp+2A0]
       mov       eax,ecx
       mov       r12d,ebp
       mov       ebp,eax
       jmp       near ptr M03_L09
M03_L144:
       mov       [rsp+130],r10
       jmp       near ptr M03_L143
M03_L145:
       mov       rax,[rsp+138]
       mov       r10,[rsp+130]
       cmp       r12d,9
       jne       near ptr M03_L152
       mov       [rsp+138],rax
       mov       rcx,rax
       mov       [rsp+130],r10
       mov       rdx,r10
       call      qword ptr [7FFD3446FE58]
       test      eax,eax
       mov       r8d,[rsp+2B4]
       je        near ptr M03_L36
       mov       rax,[rsp+138]
       mov       rdx,[rax+8]
       mov       rcx,rdx
       mov       [rsp+100],rcx
       test      rcx,rcx
       je        near ptr M03_L151
       mov       r11,offset MT_System.String
       cmp       [rcx],r11
       jne       near ptr M03_L165
M03_L146:
       lea       r8,[rsp+288]
       mov       rcx,r15
       mov       rdx,[rsp+100]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34114630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L150
       mov       rcx,[rsp+288]
       mov       rdx,[rsp+288]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       [rsp+118],rax
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+60]
       call      qword ptr [rdx+8]
       test      eax,eax
       je        near ptr M03_L153
       mov       rcx,[rsp+118]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       rcx,24E80208BF0
       cmp       rax,rcx
       jne       near ptr M03_L153
       mov       rcx,[rsp+118]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L167
       mov       r12,[rax+10]
       mov       rcx,[rsp+118]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD34246028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD340843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+110],rax
M03_L147:
       cmp       ebp,1
       jb        near ptr M03_L166
       add       rdi,2
       lea       edx,[rbp-1]
       mov       [rsp+150],rdi
       mov       [rsp+158],edx
       mov       rdx,r12
       lea       r8,[rsp+150]
       lea       rcx,[rsp+268]
       call      qword ptr [7FFD3446FE88]
       mov       rdi,[rsp+270]
       mov       ebp,[rsp+278]
       mov       [rsp+150],rdi
       mov       [rsp+158],ebp
       lea       rdx,[rsp+150]
       mov       ecx,1
       call      qword ptr [7FFD3446FF60]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+284],eax
       mov       rcx,[rsp+110]
       mov       rdx,[rsp+268]
       mov       r11,7FFD33F40708
       call      qword ptr [r11]
       mov       ecx,[rsp+284]
       cmp       ecx,8
       je        near ptr M03_L147
       cmp       ecx,0B
       jne       short M03_L148
       cmp       ebp,1
       jb        near ptr M03_L166
       add       rdi,2
       dec       ebp
M03_L148:
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD3449F210]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       byte ptr [r12+18],1
       lea       rcx,[r12+8]
       mov       rdx,[rsp+110]
       call      CORINFO_HELP_ASSIGN_REF
M03_L149:
       mov       eax,7
       mov       [rsp+128],r12
       mov       r12d,eax
       jmp       near ptr M03_L09
M03_L150:
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L36
M03_L151:
       jmp       near ptr M03_L146
M03_L152:
       mov       [rsp+138],rax
       mov       [rsp+130],r10
       jmp       near ptr M03_L34
M03_L153:
       mov       rcx,[rsp+118]
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M03_L156
       mov       rcx,[rsp+118]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r12,rax
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0F8],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+0F8]
       mov       rcx,24E80208BF0
       cmp       [rcx],ecx
       call      qword ptr [7FFD33FCA758]; Precode of System.RuntimeType.MakeGenericType(System.Type[])
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD34246028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IList
       call      qword ptr [7FFD340843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+108],rax
M03_L154:
       cmp       ebp,1
       jb        near ptr M03_L166
       lea       rdx,[rdi+2]
       lea       r8d,[rbp-1]
       mov       [rsp+150],rdx
       mov       [rsp+158],r8d
       mov       rdx,r12
       lea       r8,[rsp+150]
       lea       rcx,[rsp+248]
       call      qword ptr [7FFD3446FEA0]
       mov       rdi,[rsp+250]
       mov       ebp,[rsp+258]
       mov       [rsp+150],rdi
       mov       [rsp+158],ebp
       lea       rdx,[rsp+150]
       mov       ecx,1
       call      qword ptr [7FFD3446FF60]; Ferris.Json.JsonTransformer.GetNextToken(Ferris.Json.Token, System.ReadOnlySpan`1<Char>)
       mov       [rsp+264],eax
       mov       rcx,[rsp+108]
       mov       rdx,[rsp+248]
       mov       r11,7FFD33F406F0
       call      qword ptr [r11]
       mov       ecx,[rsp+264]
       cmp       ecx,8
       je        near ptr M03_L154
       mov       rax,[rsp+108]
       cmp       ecx,0B
       jne       short M03_L155
       cmp       ebp,1
       jb        near ptr M03_L166
       add       rdi,2
       dec       ebp
M03_L155:
       mov       rcx,rax
       mov       r11,7FFD33F406F8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FFD33FD7678]; System.Array.CreateInstance(System.Type, Int32)
       mov       r12,rax
       mov       rcx,[rsp+108]
       mov       rdx,r12
       mov       r11,7FFD33F40700
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,offset MT_Ferris.Json.TokenInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0F0],rax
       mov       rcx,rax
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFD3449F210]; Ferris.Json.TokenInfo..ctor(Ferris.Json.Token, Int32)
       mov       rax,[rsp+0F0]
       mov       byte ptr [rax+18],1
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+0F0]
       jmp       near ptr M03_L149
M03_L156:
       mov       rcx,[rsp+118]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r8d,[rsp+2B4]
       jmp       near ptr M03_L36
M03_L157:
       mov       rcx,r15
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFD340843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L158:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346AD368]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3408F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L159:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346C5980]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD34345998]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L160:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346AD188]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34345908]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L161:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346AD368]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3408F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L162:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346C5980]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD34345998]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L163:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD346AD188]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34345908]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L164:
       mov       rcx,rdx
       mov       rdx,[rsp+0E8]
       call      qword ptr [7FFD340843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L165:
       mov       rcx,r11
       call      qword ptr [7FFD340843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L166:
       call      qword ptr [7FFD3421E9D0]
       int       3
M03_L167:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6981
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFD34084348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M04_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M04_L05
M04_L00:
       mov       rax,rbx
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       ecx,1D4F
       mov       rdx,7FFD33F34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD342466E8]
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M04_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFD346C43F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD344FCCD8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFD346C4480]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFD344FCCD8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L06:
       mov       rcx,24E80203C30
       cmp       rsi,rcx
       jne       short M04_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40798
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L07:
       mov       rcx,24E80208898
       cmp       rsi,rcx
       jne       short M04_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40790
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L08:
       mov       rcx,24E80208A00
       cmp       rsi,rcx
       jne       short M04_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40788
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L09:
       mov       rcx,24E802089D8
       cmp       rsi,rcx
       jne       short M04_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40780
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,24E80208960
       cmp       rsi,rcx
       jne       short M04_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40778
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L11:
       mov       rcx,24E80208660
       cmp       rsi,rcx
       jne       short M04_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40770
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L12:
       mov       rcx,24E80204FC0
       cmp       rsi,rcx
       jne       short M04_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40768
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,24E80208988
       cmp       rsi,rcx
       jne       short M04_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40760
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L14:
       mov       rcx,24E80205F58
       cmp       rsi,rcx
       jne       short M04_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40758
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L15:
       mov       rcx,24E802089B0
       cmp       rsi,rcx
       jne       short M04_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40750
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L16:
       mov       rcx,24E80208A78
       cmp       rsi,rcx
       jne       short M04_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40748
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L17:
       mov       rcx,24E80205718
       cmp       rsi,rcx
       jne       short M04_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40740
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L18:
       mov       rcx,24E80208A28
       cmp       rsi,rcx
       jne       short M04_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFD33F40738
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L19:
       mov       rcx,24E80208AB8
       cmp       rsi,rcx
       jne       short M04_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40730
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M04_L01
M04_L20:
       mov       rcx,24E80200020
       cmp       rsi,rcx
       jne       short M04_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFD33F40728
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M04_L21:
       mov       rcx,24E802021B8
       cmp       rsi,rcx
       je        near ptr M04_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFD33F40720
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M05_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M05_L03
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       jmp       qword ptr [7FFD340843A8]
M05_L03:
       test      r8,r8
       je        short M05_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       je        short M05_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M05_L01
       test      r8,r8
       jne       short M05_L00
       jmp       short M05_L02
; Total bytes of code 71
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M06_L03
       cmp       r8,4
       jae       short M06_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L00:
       test      r8b,1
       je        short M06_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M06_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M06_L04
M06_L03:
       cmp       rcx,rdx
       je        short M06_L05
       jmp       short M06_L06
M06_L04:
       vzeroupper
       ret
M06_L05:
       mov       eax,1
       vzeroupper
       ret
M06_L06:
       cmp       r8,20
       jb        short M06_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L08
M06_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L13
       add       rax,20
       cmp       r8,rax
       ja        short M06_L07
M06_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M06_L13
       nop       dword ptr [rax]
       jmp       short M06_L05
       nop       dword ptr [rax]
M06_L09:
       cmp       r8,10
       jb        short M06_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L11
M06_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M06_L13
       add       rax,10
       cmp       r8,rax
       ja        short M06_L10
M06_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M06_L13
       jmp       near ptr M06_L05
M06_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L04
M06_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFD3E3C41F8]
       mov       rbx,rax
       lea       rsi,[rbx+3E0]
       call      qword ptr [7FFD3E3D7B80]
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFD3E3D8B78]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,[rbx+3E0]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 57
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.NewtonsoftValueMapping()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,17EF34041A0
       mov       rdi,[rsi]
       mov       rcx,17EF3404E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M00_L07
       xor       ebp,ebp
M00_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD34486B08]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbp,rbp
       jne       near ptr M00_L08
M00_L01:
       mov       rcx,rdi
       mov       r8,r14
       xor       edx,edx
       call      qword ptr [7FFD34484420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       rdx,17E80309120
       xor       r8d,r8d
       call      qword ptr [7FFD34484510]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.ValueTestObject
       cmp       [rbp],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFD340643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rbp,rax
M00_L02:
       mov       r8,[rsi]
       mov       rcx,[r8+8]
       test      rbp,rbp
       je        short M00_L05
       mov       rdx,[rbp+8]
M00_L03:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L04
       test      rdx,rdx
       je        short M00_L06
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L06
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD34115068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L06
M00_L04:
       inc       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       edx,edx
       jmp       short M00_L03
M00_L06:
       dec       dword ptr [rbx+8]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L07:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,r14
       mov       rdx,rbp
       call      qword ptr [7FFD34486B80]
       jmp       near ptr M00_L01
; Total bytes of code 281
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,17EF3404ED0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,17EF34050C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17EF3404ED8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17EF34050B0
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,17EF3400428
       mov       r13,[rcx]
       mov       rcx,17EF34014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,17E80301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,17EF3405078
       mov       rax,17EF3405080
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD3445A988
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD3411D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFD342A99F0]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFD3448ECA0]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFD33F211E0
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M03_L03
       mov       rcx,17EF3404E88
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M03_L04
       xor       r14d,r14d
M03_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFD34486B08]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M03_L05
       test      rsi,rsi
       jne       near ptr M03_L06
M03_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M03_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M03_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFD34491640]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFD3445A988
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD34226640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFD34486B80]
       test      rsi,rsi
       je        near ptr M03_L01
M03_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD34486B80]
       jmp       near ptr M03_L01
M03_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M03_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M03_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M03_L08
       mov       r11,7FFD33F21010
       call      qword ptr [r11]
M03_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M03_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M03_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M03_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M03_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M03_L11
M03_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M03_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M03_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M03_L12
       mov       r11,7FFD33F21018
       call      qword ptr [r11]
M03_L12:
       xor       eax,eax
       mov       [r14],rax
M03_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M03_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD3E3DB908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M05_L03
       cmp       r8,4
       jae       short M05_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M05_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M05_L00:
       test      r8b,1
       je        short M05_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M05_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M05_L04
M05_L03:
       cmp       rcx,rdx
       je        short M05_L05
       jmp       short M05_L06
M05_L04:
       vzeroupper
       ret
M05_L05:
       mov       eax,1
       vzeroupper
       ret
M05_L06:
       cmp       r8,20
       jb        short M05_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M05_L08
M05_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M05_L13
       add       rax,20
       cmp       r8,rax
       ja        short M05_L07
M05_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M05_L13
       nop       dword ptr [rax]
       jmp       short M05_L05
       nop       dword ptr [rax]
M05_L09:
       cmp       r8,10
       jb        short M05_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M05_L11
M05_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M05_L13
       add       rax,10
       cmp       r8,rax
       ja        short M05_L10
M05_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M05_L13
       jmp       near ptr M05_L05
M05_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M05_L04
M05_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SimpleJsonBenchmark.TextJsonValueMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,26312C041A0
       mov       rdx,[rdx]
       mov       [rsp+50],rdx
       mov       rdx,26312C04F48
       mov       rsi,[rdx]
       test      rsi,rsi
       je        near ptr M00_L15
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L16
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L17
       mov       rdx,[rdi+0B8]
       mov       r8,26300308830
       cmp       rdx,r8
       jne       near ptr M00_L17
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L10
M00_L02:
       lea       rdx,[rsp+50]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFD34476C88]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L11
       mov       rdx,26312C04F48
       mov       r14,[rdx]
       test      r14,r14
       je        near ptr M00_L12
M00_L03:
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L13
M00_L04:
       mov       r15,[r14+10]
       test      r15,r15
       je        near ptr M00_L18
       mov       rdx,[r15+0B8]
       mov       r8,26300308830
       cmp       rdx,r8
       jne       near ptr M00_L18
M00_L05:
       mov       rdx,r15
       mov       r8,rdx
       test      r8,r8
       je        short M00_L06
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L19
M00_L06:
       lea       rdx,[rbp+0C]
       mov       ecx,[rbp+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFD34667C90]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       r8,26312C041A0
       mov       r8,[r8]
       mov       rcx,[r8+8]
       test      rax,rax
       je        short M00_L09
       mov       rdx,[rax+8]
M00_L07:
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        short M00_L08
       test      rdx,rdx
       je        near ptr M00_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L14
       add       rcx,0C
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFD34105068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L14
M00_L08:
       inc       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L09:
       xor       edx,edx
       jmp       short M00_L07
M00_L10:
       call      qword ptr [7FFD340543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L11:
       mov       ecx,389E
       mov       rdx,7FFD3444A990
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3447C018]
       int       3
M00_L12:
       mov       rcx,26312C04F48
       xor       edx,edx
       call      qword ptr [7FFD34475770]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,r14
       call      qword ptr [7FFD344756C8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L04
M00_L14:
       dec       dword ptr [rbx+8]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L15:
       mov       rcx,26312C04F48
       xor       edx,edx
       call      qword ptr [7FFD34475770]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       jne       near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFD344756C8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L17:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,26300308830
       mov       r8d,1
       call      qword ptr [7FFD34474F78]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L18:
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,26300308830
       mov       r8d,1
       call      qword ptr [7FFD34474F78]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L19:
       call      qword ptr [7FFD340543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 707
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFD34475740]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,26312C02000
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFD34632E60]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,26300301C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD34476A48]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       cmp       r15d,r12d
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFD341EE9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFD3447D908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFD34627BB8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFD3444C4A0
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26312C04F88
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFD34625128]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFD346276C0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFD346252A8]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFD341EE9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFD34105BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,26312C02000
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD34632E68]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1178
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,248
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+210],rax
       mov       [rbp],rsp
       mov       rax,0CAEA0BB57BD0
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+28],rcx
       cmp       edi,55
       jle       near ptr M02_L11
       cmp       edi,15555555
       ja        short M02_L04
       mov       rdx,26312C02000
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFD34632E60]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+28],rax
M02_L01:
       test      rax,rax
       je        near ptr M02_L12
       lea       r15,[rax+10]
       mov       r14d,[rax+8]
M02_L02:
       mov       rax,r15
M02_L03:
       mov       [rbp+10],rax
       mov       [rbp+64],r14d
       jmp       short M02_L05
M02_L04:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       lea       rcx,[rbp+50]
       call      qword ptr [7FFD3447D950]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L01
M02_L05:
       mov       [rbp+50],rsi
       mov       [rbp+58],edi
       mov       rcx,[rbp+10]
       mov       [rbp+40],rcx
       mov       ecx,[rbp+64]
       mov       [rbp+48],ecx
       lea       rcx,[rbp+50]
       lea       rdx,[rbp+40]
       call      qword ptr [7FFD3447D968]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+64]
       ja        short M02_L08
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+64],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L07
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L06
       jmp       short M02_L09
M02_L06:
       mov       ecx,347F
       mov       rdx,7FFD3444A990
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3447C078]
       int       3
M02_L07:
       mov       ecx,347F
       mov       rdx,7FFD3444A990
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD3447C0C0]
       int       3
M02_L08:
       call      qword ptr [7FFD341EE9D0]
       int       3
M02_L09:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1E0],r10
       mov       [rbp+1E8],r10
       mov       byte ptr [rbp+1F0],0
       mov       byte ptr [rbp+1F1],0
       mov       byte ptr [rbp+1F2],0
       mov       byte ptr [rbp+1F3],0
       mov       byte ptr [rbp+1F4],0
       mov       byte ptr [rbp+1F5],0
       mov       [rbp+1F8],ecx
       mov       [rbp+1FC],r8b
       mov       [rbp+1FD],r9b
       mov       byte ptr [rbp+1FE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+200],xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       mov       [rbp+30],rdx
       mov       [rbp+38],eax
       lea       rdx,[rbp+30]
       lea       rcx,[rbp+120]
       lea       r9,[rbp+1E0]
       mov       r8d,1
       call      qword ptr [7FFD3466CBD0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       vmovdqu   ymmword ptr [rbp+100],ymm0
       lea       rcx,[rbp+80]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFD3466DC80]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+80]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+78]
       lea       rdx,[rbp+120]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34515938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rcx,[rbp+78]
       xor       edx,edx
       mov       [rbp+78],rdx
       mov       [rbp+20],rcx
       mov       rcx,[rbp]
       call      M02_L13
       nop
       mov       rax,[rbp+20]
       mov       rcx,0CAEA0BB57BD0
       cmp       [rbp+8],rcx
       je        short M02_L10
       call      CORINFO_HELP_FAIL_FAST
M02_L10:
       nop
       lea       rsp,[rbp+218]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r14d,100
       jmp       near ptr M02_L03
M02_L12:
       xor       r15d,r15d
       xor       r14d,r14d
       jmp       near ptr M02_L02
M02_L13:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+28],0
       je        near ptr M02_L37
       mov       rcx,[rbp+10]
       mov       edx,[rbp+64]
       mov       [rbp+70],rdx
       test      rdx,rdx
       je        short M02_L15
       cmp       rdx,300
       ja        short M02_L14
       xor       edx,edx
       mov       r8d,[rbp+70]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L15
M02_L14:
       mov       rdx,[rbp+70]
       call      qword ptr [7FFD34105BA8]
M02_L15:
       mov       rcx,26312C02000
       mov       r14,[rcx]
       mov       rcx,[rbp+28]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFD33F95120
       mov       edx,36
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M02_L16
       mov       rcx,r14
       call      qword ptr [7FFD34627C48]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M02_L16:
       xor       r12d,r12d
       mov       ebx,1
       mov       edx,[rcx+8]
       cmp       edx,r13d
       jbe       near ptr M02_L32
       mov       r12d,1
       mov       rdx,[rbp+28]
       mov       eax,10
       shlx      eax,eax,r13d
       cmp       [rdx+8],eax
       je        short M02_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFD344AD2D8]
       mov       r13,rax
       mov       ecx,1D3
       mov       rdx,7FFD33F04000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFD3405F750]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L17:
       mov       edx,r13d
       shl       rdx,4
       lea       r15,[rcx+rdx+10]
       mov       rsi,[r15]
       mov       rdx,[rbp+28]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r15+8],eax
       test      rsi,rsi
       je        near ptr M02_L32
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       short M02_L19
       mov       edx,r13d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L18
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFD34627BD0]
M02_L18:
       mov       rbx,[rax+8]
       mov       rcx,7FFD33F95120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFD33F95C38],0
       je        short M02_L20
       call      qword ptr [7FFD3405DC98]
       mov       edi,eax
       jmp       short M02_L23
M02_L19:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L20:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       edi,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rdi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M02_L21
       call      qword ptr [7FFD347F7918]
       jmp       short M02_L22
M02_L21:
       mov       eax,edi
       sar       eax,10
M02_L22:
       mov       edi,eax
M02_L23:
       mov       rcx,7FFD33F95120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,edi
       xor       edx,edx
       div       dword ptr [7FFD33F95C2C]
       mov       edi,edx
       xor       r15d,r15d
       jmp       near ptr M02_L30
M02_L24:
       cmp       edi,[rbx+8]
       jae       short M02_L19
       mov       ecx,edi
       mov       rax,[rbx+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+6C],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp+68],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L26
       test      r10d,r10d
       jne       short M02_L27
       xor       edx,edx
       mov       [rax+14],edx
M02_L25:
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp+68]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+6C],1
M02_L26:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp+6C]
       test      ecx,ecx
       je        short M02_L28
       mov       ecx,1
       jmp       short M02_L31
M02_L27:
       jmp       short M02_L25
M02_L28:
       inc       edi
       cmp       [rbx+8],edi
       jne       short M02_L29
       xor       edi,edi
M02_L29:
       inc       r15d
M02_L30:
       cmp       [rbx+8],r15d
       jg        near ptr M02_L24
       xor       ecx,ecx
M02_L31:
       mov       ebx,ecx
M02_L32:
       mov       rax,26312C005D0
       mov       r15,[rax]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp+28]
       mov       edi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,esi
       mov       r9d,edi
       mov       edx,3
       call      qword ptr [7FFD34107678]
       test      ebx,r12d
       jne       short M02_L37
       mov       rcx,[rbp+28]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,[rbp+28]
       mov       esi,[rcx+8]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r12d,r12d
       jne       short M02_L33
       mov       ecx,0FFFFFFFF
       jmp       short M02_L34
M02_L33:
       mov       ecx,r13d
M02_L34:
       mov       edx,ebx
       mov       r8d,esi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L35
       mov       eax,1
       jmp       short M02_L36
M02_L35:
       xor       eax,eax
M02_L36:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r15
       call      qword ptr [7FFD3421E2B0]
M02_L37:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1600
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       cmp       r8,8
       jae       short M03_L03
       cmp       r8,4
       jae       short M03_L02
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M03_L00
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M03_L00:
       test      r8b,1
       je        short M03_L01
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        r8d,eax
       mov       eax,r8d
M03_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L02:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M03_L04
M03_L03:
       cmp       rcx,rdx
       je        short M03_L05
       jmp       short M03_L06
M03_L04:
       vzeroupper
       ret
M03_L05:
       mov       eax,1
       vzeroupper
       ret
M03_L06:
       cmp       r8,20
       jb        short M03_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M03_L08
M03_L07:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M03_L13
       add       rax,20
       cmp       r8,rax
       ja        short M03_L07
M03_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M03_L13
       nop       dword ptr [rax]
       jmp       short M03_L05
       nop       dword ptr [rax]
M03_L09:
       cmp       r8,10
       jb        short M03_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M03_L11
M03_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M03_L13
       add       rax,10
       cmp       r8,rax
       ja        short M03_L10
M03_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M03_L13
       jmp       near ptr M03_L05
M03_L12:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L04
M03_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 307
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       lea       rax,[7FFD3E3DB908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFD344750F8]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFD34474390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M05_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFD344773A8]
       mov       [rbp-40],rax
       jmp       short M05_L01
M05_L00:
       call      qword ptr [7FFD344772A0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M05_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34475158]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFD34477330]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M05_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M05_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M06_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M06_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M06_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFD34474390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M06_L05
       call      qword ptr [7FFD344772A0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD34054360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M06_L03
       jmp       near ptr M06_L09
M06_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L09
M06_L03:
       call      qword ptr [7FFD344774B0]
       test      eax,eax
       je        near ptr M06_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFD34514450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFD34514450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFD34514480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFD34477378]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M06_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34514318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34514318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M06_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34514318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFD344756C8]
       jmp       short M06_L09
M06_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34514390]
       jmp       short M06_L09
M06_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M06_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFD34054360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M06_L07
M06_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M06_L08
M06_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M06_L08:
       cmp       dword ptr [rbp-34],0
       je        short M06_L09
       call      qword ptr [7FFD3447C978]
M06_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34475680]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M07_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34474F30]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFD34514360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       cmp       qword ptr [rbp-8],0
       je        short M07_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFD34476358]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M07_L01
M07_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M07_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFD344756E0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M07_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M07_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFD34314720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M07_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFD34475140]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFD3447CF60]
M07_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

